#include <iomanip>
#include <fstream>
#include <string>
using namespace std;

void bubblesort(double v[], string m[]);

int main()
{
	//input and output for our txt files
	ifstream insert;
	ofstream out;
	insert.open("input.txt");
	out.open("output.txt");
	//holds the value brought in from txt
	double input;
	//holds our rain values
	double values[12];
	//holds each month so that we can sort both arrays to know where each month is
	string months[12] = {"January", "Febuary", "March", "April", "May", "June", "July", "Augest", "September", "October", "November", "December"};

	//loop is used to read in our values
	for(int i = 0; i < 12; i++){
		insert >> input;
		values[i] = input;
	}

	//finding our average by adding all then dividing by 12
	double avg = 0;
	for (int i = 0; i < 12; i++)
		avg = avg + values[i];
	avg = avg / 12;


	//loop traces entire array and keeps replacing till it finds a max and min
	double max = values[0];
	//using these so we dont have to keep track of where the months are after bubblesort
	string maxMonth;
	double min = values[0];
	string minMonth;
	for (int i = 1; i < 12; i++) {
		if (values[i] > max) {
			//replaces our current max with that value if its higher
			max = values[i];
			maxMonth = months[i];
		}
		//same as max just with minimums
		if (values[i] < min) {
			min = values[i];
			minMonth = months[i];
		}
	}

	//made a function to make it easier to read
	bubblesort(values, months);

	//outputing all our info with a precision of 2 decimal places
	out << fixed << setprecision(2) << showpoint;
	out << "Monthly Rainfall for Fort Worth, TX 2014" << endl << endl;
	out << "Minimum: " << minMonth << ": " << min << endl;
	out << "Maximum: " << maxMonth << ": " << max << endl;
	out << "Monthly Average: " << avg << endl << endl;
	out << "Sorted by Total Rainfall" << endl;
	out << "Month"<< setw(15) << "Inches" << endl;
	for (int i = 0; i < 12; i++)
		out << months[i] << setw(15) << values[i] << endl;
	
	return 0;
}

void bubblesort(double v[], string m[]) {
	double holder;
	string monthHolder;
	//looks at each value and compares it to x
	for (int x = 0; x < 12; x++) {
		for (int y = 0; y < 12; y++) {
			if (v[x] > v[y]) {
				//swaps both values when finding a smaller one
				holder = v[x];
				v[x] = v[y];
				v[y] = holder;
				//does the same but for months
				monthHolder = m[x];
				m[x] = m[y];
				m[y] = monthHolder;
			}
		}
	}
}