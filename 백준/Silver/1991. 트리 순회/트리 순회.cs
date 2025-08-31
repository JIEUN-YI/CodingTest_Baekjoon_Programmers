
using System.Text;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            BinaryTree<string> tree = new BinaryTree<string>();
            int.TryParse(sr.ReadLine(), out int count);
            while (count > 0)
            {
                string[] input = sr.ReadLine().Split(" ");
                Node<string> node = new Node<string>(input[0], input[1], input[2]);
                if (count == 1)
                {
                    Console.Write("");
                }
                tree.Inset(node);
                count--;
            }
            tree.PreOrder(tree.RootNode);
            tree.sb.AppendLine();
            tree.InOrder(tree.RootNode);
            tree.sb.AppendLine();
            tree.PostOrder(tree.RootNode);
            tree.sb = tree.sb.Replace(".", "");

            Console.WriteLine(tree.sb.ToString());
        }
    }

    /// <summary>
    /// 노드 클래스 생성
    /// - 문제에서의 노드는 char 형이므로 클래스의 데이터도 char 형으로 가능
    /// - <T>를 활용하여 제너릭으로 선언 해보기
    /// - 이진 트리이므로 자식 노드는 2개 뿐
    /// </summary>
    class Node<T>
    {
        public T node; // 현재 노드 데이터
        public Node<T> rootNode; // 뿌리 노드 노드
        public Node<T> leftNode; // 왼쪽 자식 노드
        public Node<T> rightNode; // 오른쪽 자식 노드

        public Node(T nowNode)
        {
            this.node = nowNode;
        }
        public Node(T nowNode, T leftN, T rightN)
        {
            this.node = nowNode;
            this.leftNode = new Node<T>(leftN);
            this.rightNode = new Node<T>(rightN);
        }
        public Node(T nowNode, T rootN, T leftN, T rightN)
        {
            this.node = nowNode;
            this.rootNode = new Node<T>(rootN);
            this.leftNode = new Node<T>(leftN);
            this.rightNode = new Node<T>(rightN);
        }
    }

    /// <summary>
    /// 노드를 관리하는 트리
    /// </summary>
    class BinaryTree<T>
    {
        public Node<T> RootNode;
        public StringBuilder sb = new StringBuilder();
        /// <summary>
        /// 삽입할 노드의 기본 데이터의 루트 노트를 찾아서 삽입하기
        /// </summary>
        /// <param name="InsertNode"></param>
        public void Inset(Node<T> InsertNode)
        {
            if (RootNode == null)
            {
                RootNode = InsertNode;
                return;
            }
            Serch(RootNode, InsertNode); // 위치를 찾아서 삽입
        }
        /// <summary>
        /// 현재 노드를 기준으로 재귀함수로 위치를 찾아서 삽입
        /// 주의
        /// 1. 루트 노트와 삽입 노트를 쌍방으로 연결
        /// 2. 현재 노드를 기준으로 삽입 노트가 왼쪽/오른쪽 노드에 위치하는지 확인 필수
        /// 3. 현재 노드를 기준으로 왼쪽/오른쪽 노드가 NULL값인 경우의 예외 처리 필요
        /// </summary>
        /// <param name="nowNode"></param>
        /// <param name="insertNode"></param>
        /// <returns></returns>
        public Node<T> Serch(Node<T> nowNode, Node<T> insertNode)
        {
            // 루트 노드의 왼쪽 노드의 값 == 현재 노드의 노드 값
            if (nowNode.leftNode != null)
            {
                if (Equals(nowNode.leftNode.node, insertNode.node))
                {
                    nowNode.leftNode = insertNode;
                    insertNode.rootNode = nowNode;
                    return insertNode;
                }
            }
            if (nowNode.rightNode != null)
            {
                // 루트 노드의 오른쪽 노드의 값 == 현재 노드의 노드 값
                if (Equals(nowNode.rightNode.node, insertNode.node))
                {
                    nowNode.rightNode = insertNode;
                    insertNode.rootNode = nowNode;
                    return insertNode;
                }
            }
            else
            {
                return null;
            }
            // 둘 다 아닌 경우 그 자식 노드를 검색

            Node<T> left = Serch(nowNode.leftNode, insertNode);
            Node<T> right = Serch(nowNode.rightNode, insertNode);
            if (left != null)
            {
                return left;
            }
            else if (right != null)
            {
                return right;
            }
            return null;

        }

        /// <summary>
        /// 전위순회
        /// 중앙 -> 왼쪽 -> 오른쪽
        /// </summary>
        public void PreOrder(Node<T> rootNode)
        {
            if(rootNode != null)
            {
                sb.Append(rootNode.node);
                PreOrder(rootNode.leftNode);
                PreOrder(rootNode.rightNode);
            }
        }
        /// <summary>
        /// 중위순회
        /// 왼쪽->중앙->오른쪽
        /// </summary>
        public void InOrder(Node<T> rootNode)
        {
            if (rootNode != null)
            {
                InOrder(rootNode.leftNode);
                sb.Append(rootNode.node);
                InOrder(rootNode.rightNode);
            }
        }
        /// <summary>
        /// 후위 순회
        /// 왼쪽->오른쪽->중앙
        /// </summary>
        public void PostOrder(Node<T> rootNode)
        {
            if (rootNode != null)
            {
                PostOrder(rootNode.leftNode);
                PostOrder(rootNode.rightNode);
                sb.Append(rootNode.node);
            }
        }
    }


}