#ifndef LOCKER_RENTAL_SYSTEM_H
#define LOCKER_RENTAL_SYSTEM_H

// Constants
#define MAX_LOCKERS 100
#define MAX_ITEM_LENGTH 100

// Function prototypes

// Function to view a locker's contents
void viewLocker(char lockers[][MAX_ITEM_LENGTH], int lockerNumber);

// Function to rent a locker
void rentLocker(char lockers[][MAX_ITEM_LENGTH], int lockerNumber, char valueString[]);

// Function to end a locker rental
void endRental(char lockers[][MAX_ITEM_LENGTH], int lockerNumber);

// Function to list all rented lockers
void listLockerContents(char lockers[][MAX_ITEM_LENGTH]);

#endif // LOCKER_RENTAL_SYSTEM_H