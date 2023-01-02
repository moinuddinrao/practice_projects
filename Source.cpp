#include <iostream>
#include <fstream>
#include <string>
#include <iomanip>
#include <stdlib.h> 
using namespace std;

// Global variables
const double COMMISSION_RATE = 0.1;

int n;		// no of sellers
int f;		// no of food items

int i, j;

// food item structure with name, and price
struct FoodItem {
	string name;
	double price;
	int quantity;
	string seller;
};

// customer structure with name, pin, and outstanding balance
struct Customer {
	string name;
	int pin;
	double balance;
};

// seller structure with name, pin, food item, and outstanding balance
struct Seller {
	string name;
	int pin;
	double balance;
};

// delivery service provider structure with name, pin, and outstanding balance
struct DeliveryServiceProvider {
	string name;
	int pin;
	double balance;
};

// order structure with food item, customer, seller, delivery service provider, and status
struct Order {
	FoodItem item;
	Customer customer;
	Seller seller;
	DeliveryServiceProvider provider;
	string status;
};

// add customer data
void addCustomer(struct Customer& c)
{
	cout << left << setw(60) << "------------------------------------------------------------" << endl;
	cout << "\t\t ADDING CUSTOMER DATA" << endl;
	cout << left << setw(60) << "------------------------------------------------------------" << endl;

	cout << "Enter the name of customer: ";
	cin.clear(); cin.ignore();
	getline(cin, c.name);

	cout << "Enter the pin of customer: ";
	cin >> c.pin;

	cout << "Enter the balance of customer: ";
	cin >> c.balance;
}

// add seller data
void addSeller(struct Seller s[])
{
	cout << left << setw(60) << "------------------------------------------------------------" << endl;
	cout << "\t\t ADDING SELLER DATA" << endl;
	cout << left << setw(60) << "------------------------------------------------------------" << endl;

	for (i = 0; i < n; i++)
	{
		cout << "\nSeller number " << i + 1 << endl;

		cout << "Enter the name of seller: ";
		cin.clear(); cin.ignore();
		getline(cin, s[i].name);

		cout << "Enter the pin number: ";
		cin >> s[i].pin;

		cout << "Enter the balance of seller: ";
		cin >> s[i].balance;
	}
}

// add food data
void addFoodItems(struct FoodItem item[])
{
	cout << left << setw(60) << "------------------------------------------------------------" << endl;
	cout << "\t\t ADDING FOOD DATA" << endl;
	cout << left << setw(60) << "------------------------------------------------------------" << endl;

	cin.clear(); cin.ignore();
	for (i = 0; i < f; i++)
	{
		cout << "\nItem number " << i + 1 << endl;

		cout << "Enter the name of item: ";
		getline(cin, item[i].name);

		cout << "Enter the price of item: ";
		cin >> item[i].price;

		cout << "Enter the quantity of item: ";
		cin >> item[i].quantity;

		cout << "Enter the name of seller: ";
		cin.clear(); cin.ignore();
		getline(cin, item[i].seller);
	}
}

// add delivery service provider data
void addDSP(struct DeliveryServiceProvider& dsp)
{
	cout << left << setw(60) << "------------------------------------------------------------" << endl;
	cout << "\t\t ADDING DELIVERY SERVICE PROVIDER DATA" << endl;
	cout << left << setw(60) << "------------------------------------------------------------" << endl;

	cout << "Enter the name of DSP: ";
	cin.clear(); cin.ignore();
	getline(cin, dsp.name);

	cout << "Enter the pin number: ";
	cin >> dsp.pin;

	cout << "Enter the balance of DSP: ";
	cin >> dsp.balance;
}

// sort the food items
void bubble_sort(FoodItem data[]) {
	for (int i = 0; i < f - 1; i++) {
		for (int j = 0; j < f - i - 1; j++) {
			if (data[j].price > data[j + 1].price) {
				swap(data[j], data[j + 1]);
			}
		}
	}
}

// search for food item
void searchItem(struct FoodItem items[])
{
	string itemName;
	cout << "\nEnter the name of the food item: ";
	cin.clear(); cin.ignore();
	getline(cin, itemName);

	// sorting list of items based on item price
	bubble_sort(items);

	// printing the food items	
	cout << left << setw(60) << "------------------------------------------------------------" << endl;
	cout << "\t\t AVAILABLE FOOD MENU" << endl;
	cout << left << setw(60) << "------------------------------------------------------------" << endl;

	cout
		<< left
		<< setw(20)
		<< "Item Name"
		<< right
		<< setw(10)
		<< "Price"
		<< right
		<< setw(10)
		<< "Quantity"
		<< right
		<< setw(20)
		<< "Seller"
		<< endl;

	for (i = 0; i < f; i++)
	{
		if (items[i].name == itemName) // search if the food item exist
		{
			cout
				<< left
				<< setw(20)
				<< items[i].name
				<< right
				<< setw(10)
				<< items[i].price
				<< right
				<< setw(10)
				<< items[i].quantity
				<< right
				<< setw(20)
				<< items[i].seller
				<< endl;
		}
	}
}

// placing order
void placeOrder(struct Customer& c, struct Seller s[], struct FoodItem items[], struct Order& order)
{
	cout << left << setw(60) << "------------------------------------------------------------" << endl;
	cout << "\t\t PLACING ORDER" << endl;
	cout << left << setw(60) << "------------------------------------------------------------" << endl;

	string cName, itemName, sName;
	int quantity, sellerIndex, itemIndex;

	bool flagA = true;
	bool flagB = true;
	bool flagC = true;

	cin.clear(); cin.ignore();
	cout << "Enter the name of customer: ";
	getline(cin, cName);
	cout << "Enter the name of food item: ";
	getline(cin, itemName);
	cout << "Enter the name of seller: ";
	getline(cin, sName);
	cout << "Enter the item quantity: ";
	cin >> quantity;

	// check if the customer exists
	if (c.name != cName)
	{
		flagA = false;
	}

	// check if the seller exists
	for (int i = 0; i < n; i++)
	{
		if (s[i].name == sName)
		{
			flagB = true;
			sellerIndex = i;
			break;
		}
		else
		{
			flagB = false;
		}
	}

	// check if the food item exists
	// for that particular seller
	// and is available
	for (int i = 0; i < f; i++)
	{
		if (items[i].name == itemName && items[i].seller == sName && items[i].quantity >= quantity)
		{
			itemIndex = i;
			flagC = true;
			break;
		}
		else
		{
			flagC = false;
		}
	}

	// create a new order
	if (flagA && flagB && flagC)
	{
		items[itemIndex].quantity--;

		order.customer = c;
		order.seller = s[sellerIndex];
		order.item = items[itemIndex];
		order.item.quantity = quantity;

		order.status = "pending";
		cout << "Order placed successfully!" << endl;
	}
	else
	{
		cout << "Order can not be placed, Try again!" << endl;
	}
}

// confirm order
void confirmOrder(struct Order& order)
{
	cout << left << setw(60) << "------------------------------------------------------------" << endl;
	cout << "\t\t CONFIRMING ORDER" << endl;
	cout << left << setw(60) << "------------------------------------------------------------" << endl;

	string cName;
	int pin;

	cin.clear(); cin.ignore();
	cout << "Enter the name of customer: ";
	getline(cin, cName);
	cout << "Enter your pin: ";
	cin >> pin;

	// check if the customer exists
	// check if the pin is correct
	// find the pending order for the customer	
	if (order.customer.name == cName && order.customer.pin == pin && order.status == "pending")
	{
		double finalCost = order.item.price * order.item.quantity;

		// add the food company's commission to the final cost
		finalCost += finalCost * COMMISSION_RATE;

		// update the outstanding balances of the customer and seller
		order.customer.balance += finalCost;
		order.seller.balance += finalCost;

		// mark the order as successful
		order.status = "success";
		cout << "Order confirmed successfully!" << endl;
	}
	else
	{
		cout << "Order can not be confirmed, Try again!" << endl;
	}
}

// Deliver Order
void deliverOrder(struct DeliveryServiceProvider& dsp, struct Order& order)
{

	cout << left << setw(60) << "------------------------------------------------------------" << endl;
	cout << "\t\t DELIVERING ORDER" << endl;
	cout << left << setw(60) << "------------------------------------------------------------" << endl;

	string cName;
	int pin;

	cin.clear(); cin.ignore();
	cout << "Enter the name of customer: ";
	getline(cin, cName);
	cout << "Enter your pin: ";
	cin >> pin;

	// check if the customer exists
	// check if the pin is correct
	// find the successful order for the customer
	if (order.customer.name == cName && order.customer.pin == pin && order.status == "success")
	{
		// assign the delivery service provider to the order and mark the order as marked for delivery
		order.provider = dsp;

		order.status = "marked for delivery";
		cout << "Order marked for delivery successfully!" << endl;
	}
	else
	{
		cout << "Order can not be delivered, Try again!" << endl;
	}
}

// confirm Delivery
void confirmDelivery(struct Order& order)
{

	cout << left << setw(60) << "------------------------------------------------------------" << endl;
	cout << "\t\t CONFIRMING DELIVERY" << endl;
	cout << left << setw(60) << "------------------------------------------------------------" << endl;

	string dspName;
	int pin;

	cin.clear(); cin.ignore();
	cout << "Enter the name of dsp: ";
	getline(cin, dspName);
	cout << "Enter your pin: ";
	cin >> pin;

	// check if the DSP exists
	// check if the pin is correct
	// find the marked for delivery order for the delivery service provider

	if (order.provider.name == dspName && order.provider.pin == pin && order.status == "marked for delivery")
	{
		// add the food company's commission to the outstanding balance of the delivery service provider
		double commission = order.item.price * order.item.quantity * COMMISSION_RATE;
		order.provider.balance += commission;

		// mark the order as completed
		order.status = "completed";
		cout << "Delivery confirmed successfully!" << endl;
	}
	else
	{
		cout << "Delivery can not be confirmed, Try again!" << endl;
	}
}

// print reciept
void printReciept(struct Order& order)
{
	cout << left << setw(60) << "------------------------------------------------------------" << endl;
	cout << "\t\t ORDER RECIEPT" << endl;
	cout << left << setw(60) << "------------------------------------------------------------" << endl;

	double cost = order.item.price * order.item.quantity;
	double commission = cost * COMMISSION_RATE;

	cout
		<< left
		<< setw(20)
		<< "Item Name"
		<< right
		<< setw(10)
		<< "Price"
		<< right
		<< setw(10)
		<< "Quantity"
		<< right
		<< setw(20)
		<< "COMMISSION(10%)"
		<< endl;

	cout
		<< left
		<< setw(20)
		<< order.item.name
		<< right
		<< setw(10)
		<< order.item.price
		<< right
		<< setw(10)
		<< order.item.quantity
		<< right
		<< setw(20)
		<< commission
		<< endl;

	cout << left << setw(60) << "------------------------------------------------------------" << endl;

	cout << left << setw(40) << "Cost" << right << setw(20) << cost << endl;
	cout << left << setw(40) << "Commission" << right << setw(20) << commission << endl;
	cout << left << setw(40) << "Total Price" << right << setw(20) << cost + commission << endl;

	cout << left << setw(60) << "------------------------------------------------------------" << endl;
}

// Main Program
int main() {
	Customer customer;
	Seller* sellers;
	FoodItem* items;
	DeliveryServiceProvider dsp;
	Order order;

	int choice;
	bool exit = false;

	while (!exit)
	{
		cout << "Welcome to the Food Delivery Application!" << endl;
		cout << "1. Add customer data" << endl;
		cout << "2. Add sellers data" << endl;
		cout << "3. Add food items data" << endl;
		cout << "4. Add delivery service provider data" << endl;
		cout << "5. Search for food item" << endl;
		cout << "6. Place order" << endl;
		cout << "7. Confirm order" << endl;
		cout << "8. Mark order for delivery" << endl;
		cout << "9. Confirm delivery" << endl;
		cout << "10. Print Reciept" << endl;
		cout << "0. Exit" << endl;

		cout << "Enter your choice: ";
		cin >> choice;

		switch (choice)
		{
		case 1:
		{
			addCustomer(customer);

			cout << endl << flush;
			system("PAUSE");
			system("CLS");
			break;
		}
		case 2:
		{
			cout << "\nEnter number of sellers: ";
			cin >> n;
			sellers = new Seller[n];
			addSeller(sellers);

			cout << endl << flush;
			system("PAUSE");
			system("CLS");
			break;
		}
		case 3:
		{
			cout << "\nEnter number of food istems ";
			cin >> f;
			items = new FoodItem[f];
			addFoodItems(items);

			cout << endl << flush;
			system("PAUSE");
			system("CLS");
			break;
		}
		case 4:
		{
			addDSP(dsp);

			cout << endl << flush;
			system("PAUSE");
			system("CLS");
			break;
		}
		case 5:
		{
			searchItem(items);

			cout << endl << flush;
			system("PAUSE");
			system("CLS");
			break;
		}
		case 6:
		{
			placeOrder(customer, sellers, items, order);

			cout << endl << flush;
			system("PAUSE");
			system("CLS");
			break;
		}

		case 7:
		{
			confirmOrder(order);

			cout << endl << flush;
			system("PAUSE");
			system("CLS");
			break;
		}

		case 8:
		{
			deliverOrder(dsp, order);

			cout << endl << flush;
			system("PAUSE");
			system("CLS");
			break;
		}

		case 9:
		{
			confirmDelivery(order);

			cout << endl << flush;
			system("PAUSE");
			system("CLS");
			break;
		}

		case 10:
		{
			printReciept(order);

			cout << endl << flush;
			system("PAUSE");
			system("CLS");
			break;
		}

		case 0:
		{
			cout << "Exiting the application" << endl << flush;
			exit = true;

			cout << endl << flush;
			system("PAUSE");
			system("CLS");
			break;
		}

		default:
		{
			cout << "Invalid choice!" << endl;

			cout << endl << flush;
			system("PAUSE");
			system("CLS");
			break;
		}
		}
	}
	return 0;
}