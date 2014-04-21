#include<vector>
#include<string>
#include<sstream>
using namespace std;
class Time{
public:
	string whatTime(int seconds){
		int h=0,m=0,s=0;
		stringstream sst;
		string ans;
		while(seconds>=3600){
			seconds-=3600;
			h++;
		}
		while(seconds>=60){
			seconds-=60;
			m++;
		}
		while(seconds>0){
			seconds--;
			s++;
		}
		sst<<h<<":"<<m<<":"<<s;
		ans = sst.str();
		return ans;
		}
};