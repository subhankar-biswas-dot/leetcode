#include<bits/stdc++.h>
using namespace std;
class DSU{
    int *parent,*rank,n;
    public:
        DSU(int n){
            parent=new int[n];
            rank = new int[n];
            this->n=n;
            makeParent();
        }
        void makeParent(){
            for(int i=0;i<n;i++){
                parent[i]=i;
            }
        }
        
        int find(int x){
            if(parent[x]!=x){
                parent[x]=find(parent[x]);
            }
            return parent[x];
        }
        void Union(int x,int y){
            int xset =find(x);
            int yset=find(y);
            if(xset==yset)
                return;
            if(rank[xset]<rank[yset])
                parent[xset]=yset;
            if(rank[yset]<rank[xset])
                parent[yset]=xset;
            else{
                parent[yset]=parent[xset];
                rank[xset]++;
            }
        }      
};

class Solution {
public:
    vector<int> findRedundantConnection(vector<vector<int>>& edges) {
        for(int i=edges.size()-1;i>=0;i--){
            DSU *obj=new DSU(edges.size());
            for(int j=0;j<edges.size();j++){
                if(i==j) continue;
                obj->Union(edges[j][0],edges[j][1]);
            }
            if(obj->find(edges[i][0])==obj->find(edges[i][1])){
                cout<<edges[i][0]<<" "<<edges[i][1]<<endl;
                break;

            }
                
         }
        return edges[0];
    }
};
int find(vector<int> &parent,int i){
        if(parent[i]==-1 || parent[i]==i)
            return i;
        return find(parent,parent[i]);
    }
    void Union(vector<int> &parent,int x,int y){
        int xset = find(parent, x);
        int yset = find(parent, y);
        parent[xset]=yset;
    }
int main(){
    vector<vector<int>> edges = {{1,2},{2,3},{3,4},{1,4},{1,5}};
    // for(int i=edges.size()-1;i>=0;i--){
    //         DSU obj(edges.size());
    //         for(int j=0;j<edges.size();j++){
    //             if(i==j) continue;
    //             obj.Union(edges[j][0],edges[j][1]);
    //         }
    //         if(obj.find(edges[i][0])==obj.find(edges[i][1])){
    //             cout<<edges[i][0]<<" "<<edges[i][1]<<endl;

    //         }
                
    //      }
    for(int i=edges.size()-1;i>=0;i--){
            vector<int> parent(edges.size()+1,-1);
            for(int j=0;j<edges.size();j++){
                if(i==j)  continue;
                Union(parent,edges[j][0]-1,edges[j][1]-1);
            }
            if(find(parent,edges[i][0]-1)==find(parent,edges[i][1]-1)){
                cout<< edges[i][0]<<edges[i][1]<<endl;
            }
            
            // else{
            //     cout<<"\n";
            //     for(int i: parent){
            //         cout<<i<<" ";
            //     }
            //     cout<<endl;
            // }
        }
        
    
}