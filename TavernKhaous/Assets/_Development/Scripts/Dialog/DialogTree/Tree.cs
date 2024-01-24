using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree
{
    private TreeNode<string> treeRoot;

    public void BuildTree()
    {
        treeRoot = new TreeNode<string>("Bem-vindo ao Reino M�gico!");
        {
            TreeNode<string> Option1 = treeRoot.AddChild(" [Op��o 1] Como posso chegar � Cidade dos Magos?");
            {
                TreeNode<string> Option11 = Option1.AddChild("Answer: Voc� pode chegar � Cidade dos Magos atravessando a Floresta Encantada.");
                {
                    TreeNode<string> Option111 = Option11.AddChild("[Opcao 1.1.1] Pode me dar um mapa?");
                    TreeNode<string> Option112 = Option11.AddChild("[Opcao 1.1.2] Como est� a seguran�a na floresta?");
                }
            }
            TreeNode<string> Option2 = treeRoot.AddChild("[Op��o 2] O que voc� vende aqui?");
        }
    }

    public void PrintTree()
    {
        Debug.Log("--iniciou--");
        //for (int i = 0; i < treeRoot._children.Count; i++)
        //{
        //while there is child on node
        //while(treeRoot._children.Count > 0)
        //{
        PrintNodeData(treeRoot);
        //}
        //}
        Debug.Log("--finalizou--");
    }

    private void PrintNodeData <T> (TreeNode<T> node)
    {
        Debug.Log(node.data);

        for (int j = 0; j < node._children.Count; j++)
        {
            PrintNodeData(node._children[j]);
        }

        return;
    }
}
