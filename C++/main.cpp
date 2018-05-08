#include <iostream>
using namespace std;
/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char** argv) {

// ACC VR & AR Diploma
// Gerges Romany
int num;
int x;
for (num=1; num<=12; num++) {
  cout<<"<--------- "<<num<<" ----------->";
  for (x = 1; x<=12; x++) {
    cout<<endl<<num << "*" << x << "=" << (num*x);
  }
  x=1;
  cout<<"\n";
}
	return 0;
}
