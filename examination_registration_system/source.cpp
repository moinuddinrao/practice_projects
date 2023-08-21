#include <iostream>
#include <cstring>
#include <string>
#include<fstream>
using namespace std;

int option ;
int i = 0;
int n = 0;
int c = 2;
int j = 0;
float present = 75.00;
float tdays = 1;

// Letter Grade
const double A = 4.0;
const double A_MINUS = 3.67;
const double B_PLUS = 3.33;
const double B = 3.0;
const double B_MINUS = 2.67;
const double C_PLUS = 2.33;
const double C = 2.0;
const double C_MINUS = 1.67;
const double D = 1.00;
const double F = 0.0;
// Structure of Student
struct course {
	string name;
	int credit;
	int assignment;
	int quiz;
	int project;
	int mids;
	int finals;
	double grade;
};

struct student {
	char name[20];
	int rno;
	float days;
	float attend;
	struct course courses[2];
} s[50];


// Functions
void add(struct student s[]);
void eligibleStudents(struct student s[]);
void execute();
void printStudents(struct student s[]);
void deleteRecord(struct student s[]);
void GPA(struct student s[]);
double grade (int obtainedMarks, int credit);

// Function to execute the software
// for the student examination
// registration system
void execute()
{
	cout<<
		"\n Enter the serial number"
		"to select the option"<<endl;
	cout<<" 1. To show Eligible"
		"candidates"<<endl;
	cout<<" 2. To delete the "
		"student record"<<endl;
	cout<<" 3. To change the "
		"eligibility criteria"<<endl;
	cout<<" 4. Reset the "
		"eligibility criteria"<<endl;
	cout<<" 5. Print the list "
		"of all the student"<<endl;
	cout<<" 6. To view GPA"<<endl;
	cout<<" Enter 0 to exit"<<endl;
	
	cin>>option;

	// Switch Statement for choosing
	// the desired option for the user
	switch (option) {
	case 1:
		eligibleStudents(s);
		execute();
		break;

	case 2:
		deleteRecord(s);
		execute();
		break;

	case 3:
		cout<<"Old Attendance required = "<<present<<endl;
		cout<<"\n Enter the updated attendance required"<<endl;
		cin>>present;
		cout<<"Eligibility Criteria updated"<<endl;
		execute();
		break;

	case 4:
		present = 75.00;
		cout<<"Eligibility critetria reset"<<endl;
		execute();
		break;

	case 5:
		printStudents(s);
		execute();
		break;

	case 6:
		GPA(s);
		execute();
		break;

	case 0:
		exit(0);

	default:
		cout<<"Enter number only from 0-6"<<endl;
		execute();
	}
}

// Function to print the students record
void printStudents(struct student s[])
{
	// Loop to iterate over the students
	// students records
	for (i = 0; i < n; i++) {

		cout<<"\nName of student "<<s[i].name<<endl;
		cout<<"\nStudent roll number "<<s[i].rno<<endl;
	
		cout<<"\nStudent number of days present "<<s[i].days<<endl;
		cout<<"\nStudent attendance "<<s[i].attend<<endl;
	}
	
}

// Function to Student Record
void deleteRecord(struct student s[])
{
	int a = 0;
	cout<<"\nEnter the roll number of "
		"the student to delete it ";
	cin>>a;

	// Loop to iterate over the students
	// records to delete the Data
	for (i = 0; i <= n; i++) {
		// Condition to check the current
		// student roll number is same as
		// the user input roll number
		if (s[i].rno == (a)) {

			// Update record at ith index
			// with (i + 1)th index
			for (j = i; j < n; j++) {
				strcpy(s[j].name, s[j + 1].name);
				s[j].rno = s[j + 1].rno;
				s[j].days = s[j + 1].days;
				s[j].attend = s[j + 1].attend;
			}
			cout<<"\nStudent Record deleted"<<endl;
		}
	}
}

// Function to print the student
// details of the eligible students
void eligibleStudents(struct student s[])
{
	cout<<endl<<endl<<endl;
	cout<<"\nQualified Students for Examination"<<endl;

	// Iterate over the list
	// of the students records
	for (i = 0; i < n; i++) {
		// Check for the eligibility
		// of the student
	 {
			if (s[i].attend >= present) {
				cout<<"\nStudent name "<<s[i].name<<endl;
				cout<<"\nStudent roll no. "<<s[i].rno<<endl;
				cout<<" \nStudent attendance "<<s[i].attend<<endl;
			}
		}
	}
}
// Function to add the students record
void add(struct student s[]) {
	cout<<"---------------------------------------------------------"<<endl;
	cout<<"\t\t\t ADDING RECORDS"<<endl;
	cout<<"---------------------------------------------------------"<<endl;

	cout<<"Enter the number of students ";
	cin>>n;

	for (i = 0; i < n; i++) 
	{

		cout<<"\nStudent number "<<i + 1<<endl;

		cout<<"\nEnter the name of the student "<<endl;
		cin>>s[i].name;
	
		cout<<"\nEnter the roll number "<<endl;
		cin>>s[i].rno;
        
        cout<<"\nEnter the number of days the student was present "<<endl;
		cin>>s[i].days;
		

		s[i].attend = (s[i].days/ tdays)* 100;
		cout<<"\nStudent attendance "<<s[i].attend<<"%"<<endl;
	
	

		for (j = 0; j < c; j++) 
		{

			cout<<"\nCourse number "<<j + 1<<endl;
	
			cout<<"\nEnter the name of the course ";
			cin>>s[i].courses[j].name;
	
			cout<<"\nEnter the credit hours ";
			cin>>s[i].courses[j].credit;
			
			cout<<"\nEnter assignment weightage ";
			cin>>s[i].courses[j].assignment;
			
			cout<<"\nEnter the quizzes weightage ";
			cin>>s[i].courses[j].quiz;
			
			cout<<"\nEnter the mids weightage ";
			cin>>s[i].courses[j].mids;
			
			cout<<"\nEnter the projects weightage ";
			cin>>s[i].courses[j].project;
			
			cout<<"Enter the finals weightage ";
			cin>>s[i].courses[j].finals;
			
			
		}
	}
	execute();
}

// Grade
double grade (int obtainedMarks, int credit) {
	if (obtainedMarks >= 80)
    {
    	cout<<"Grade A"<<endl;
        return credit * A;
    }
    else if (obtainedMarks >= 75){
        return credit * A_MINUS;
    }
    else if (obtainedMarks >= 70){
       return credit * B_PLUS;
    }
    else if (obtainedMarks >= 65){
        return credit * B;
    }
    else if (obtainedMarks >= 60){
       return credit * B_MINUS;
    }
    else if (obtainedMarks >= 55){
        return credit * C_PLUS;
    }
    else if (obtainedMarks >= 50){
        return credit * C;
    }
    else if (obtainedMarks >= 45){
       return credit * C_MINUS;
    }
    else if (obtainedMarks >= 40){
       return credit * D;
    }
    else
    {
        return credit * F;
    }
}

// GPA
void GPA(struct student s[]){
	int obtainedMarks;
    double totalGP = 0;
	double totalCH = 0;
	
	cout<<"---------------------------------------------------------"<<endl;
	cout<<"\t\t\t GPA"<<endl;
	cout<<"---------------------------------------------------------"<<endl;

	for (i = 0; i < n; i++) 
	{

		cout<<"\nStudent number "<<i + 1<<endl;

		cout<<"\nName of student "<<endl;
		cout<<s[i].name;

		cout<<"\nRoll number "<<endl;
		cout<<s[i].rno;

		// Calculating grade of every course
		for (j = 0; j < c; j++) 
		{

			cout<<"\nCourse number "<<j + 1<<endl;

			cout<<"\nName of the course ";
			cout<<s[i].courses[j].name<<endl;
			
			
			cout<<"\nCredit hours ";
			cout<<s[i].courses[j].credit<<endl;
			
			cout<<"\nObtained marks ";
			obtainedMarks = s[i].courses[j].assignment+s[i].courses[j].quiz+s[i].courses[j].project+s[i].courses[j].mids+s[i].courses[j].finals;
			cout<<obtainedMarks<<"/100"<<endl;
			
			cout<<"\nGrade of course"<<endl;
			s[i].courses[j].grade = grade(obtainedMarks, s[i].courses[j].credit);
			cout<<"\nGrade Points "<<s[i].courses[j].grade<<endl;
			
			totalGP += s[i].courses[j].grade;
			totalCH += s[i].courses[j].credit;
		}
		cout<<"\nGPA of student "<<
			totalGP/totalCH<<endl;
	}
	
}


// Driver Code
int main()
{
	cout<<"Welcome Air University Examination Management System"<<endl;

	cout<<"Enter 0 to exit"<<endl;
	cout<<"Enter 1 to Add Student Record"<<endl;

	cin>>option;

	// Switch Statements
	switch (option) {
	case 0:
		exit(0);

	case 1:
		add(s);
		break;

	default:
		cout<<"Only enter 0 or 1"<<endl;
		execute();
	}
	return 0;
}
