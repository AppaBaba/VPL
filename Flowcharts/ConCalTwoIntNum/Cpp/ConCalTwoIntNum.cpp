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

int main() {
    int n, m, a;
    string cmd, more;
    bool goodtogo, doitagain;
    
    doitagain = true;
    while (doitagain == true) {
        cout << "Enter n value" << endl;
        cin >> n;
        cout << "Enter m value" << endl;
        cin >> m;
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
                a = m * n;
                goodtogo = true;
            }
            if (goodtogo == false) {
                cout << "Bad command" << endl;
            }
        }
        cout << "The answer is " << a << endl;
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
