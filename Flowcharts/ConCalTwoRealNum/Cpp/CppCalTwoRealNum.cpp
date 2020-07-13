#include <iostream>
#include <sstream>
#include <string>
#include <cstdlib>
#include <cmath>

using namespace std;

// Headers
string toString (double);
int toInt (string);
double toDouble (string);
double calCommand(double n, double m);

int main() {
    double num1, num2, ans;
    string more;
    bool doitagain;
    
    doitagain = true;
    while (doitagain == true) {
        cout << "Enter Num1 value" << endl;
        cin >> num1;
        cout << "Enter Num2 value" << endl;
        cin >> num2;
        ans = calCommand(num1, num2);
        cout << "The answer is " << ans << endl;
        cout << "Do you want to Calculate again? (yes or no)" << endl;
        cin >> more;
        if (more == "yes") {
            doitagain = true;
        } else {
            doitagain = false;
        }
    }
    cout << "The program is done" << endl;
    return 0;
}

double calCommand(double n, double m) {
    double a;
    string cmd;
    bool goodtogo;
    
    goodtogo = false;
    while (goodtogo == false) {
        cout << "Enter command" << endl;
        cin >> cmd;
        if (cmd == "add") {
            a = n + m;
            goodtogo = true;
        }
        if (cmd == "sub") {
            a = n - m;
            goodtogo = true;
        }
        if (cmd == "mul") {
            a = n * m;
            goodtogo = true;
        }
        if (cmd == "div") {
            a = n / m;
            goodtogo = true;
        }
        if (goodtogo == false) {
            cout << "Bad command" << endl;
        }
    }
    
    return a;
}

// The following implements type conversion functions.
string toString (double value) { //int also
    stringstream temp;
    temp << value;
    return temp.str();
}

int toInt (string text) {
    return atoi(text.c_str());
}

double toDouble (string text) {
    return atof(text.c_str());
}
