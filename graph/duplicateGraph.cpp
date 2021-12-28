#include<bits/stdc++.h>
using namespace std;
class Solution {
public:
    void dfs(Node* node,Node* copy,vector<Node*> &vis){
        vis[copy->val]=copy;
        for(auto i: node->neighbors){
            if(vis[i->val]==NULL){
                Node *newnode = new Node(i->val);
                (copy->neighbors).push_back(newnode);
                dfs(i,newnode,vis);
            }
            else{
                (copy->neighbors).push_back(vis[i->val]);
            }
        }
    }
    Node* cloneGraph(Node* node) {
        if(node ==NULL)return node;
        Node* copy = new Node(node->val);
        vector<Node*> vis(1000,NULL);
        dfs(node,copy,vis);
        return copy;
    }
};