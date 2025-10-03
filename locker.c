#include <stdio.h>
#include <string.h>
#include "locker_rental_system.h"

// Function to view a locker's contents
void viewLocker(char lockers[][MAX_ITEM_LENGTH], int lockerNumber) {
    // Validate locker number
    if (lockerNumber < 1 || lockerNumber > NUM_LOCKERS) {
        printf("Error: Invalid locker number. Please enter a number between 1 and %d.\n", NUM_LOCKERS);
        return;
    }
    
    // Convert to 0-indexed array
    int index = lockerNumber - 1;
    
    // Check if locker is empty
    if (strlen(lockers[index]) == 0) {
        printf("Locker %d is empty.\n", lockerNumber);
    } else {
        printf("Locker %d contains: %s\n", lockerNumber, lockers[index]);
    }
}

// Function to rent a locker
void rentLocker(char lockers[][MAX_ITEM_LENGTH], int lockerNumber, char valueString[]) {
    // Validate locker number
    if (lockerNumber < 1 || lockerNumber > NUM_LOCKERS) {
        printf("Error: Invalid locker number. Please enter a number between 1 and %d.\n", NUM_LOCKERS);
        return;
    }
    
    // Convert to 0-indexed array
    int index = lockerNumber - 1;
    
    // Check if locker is already rented
    if (strlen(lockers[index]) > 0) {
        printf("Error: Locker %d is already rented and unavailable.\n", lockerNumber);
        return;
    }
    
    // Rent the locker by storing the item
    strncpy(lockers[index], valueString, MAX_ITEM_LENGTH - 1);
    lockers[index][MAX_ITEM_LENGTH - 1] = '\0'; // Ensure null termination
    
    printf("Locker %d has been rented successfully. Item stored: %s\n", lockerNumber, valueString);
}

// Function to end a locker rental
void endRental(char lockers[][MAX_ITEM_LENGTH], int lockerNumber) {
    // Validate locker number
    if (lockerNumber < 1 || lockerNumber > NUM_LOCKERS) {
        printf("Error: Invalid locker number. Please enter a number between 1 and %d.\n", NUM_LOCKERS);
        return;
    }
    
    // Convert to 0-indexed array
    int index = lockerNumber - 1;
    
    // Check if locker is currently rented
    if (strlen(lockers[index]) == 0) {
        printf("Error: Locker %d is not currently rented.\n", lockerNumber);
        return;
    }
    
    // End the rental by clearing the locker
    printf("Rental ended for locker %d. Item removed: %s\n", lockerNumber, lockers[index]);
    lockers[index][0] = '\0';
}

// Function to list all rented lockers
void listLockerContents(char lockers[][MAX_ITEM_LENGTH]) {
    int rentedCount = 0;
    
    printf("\n=== Rented Lockers ===\n");
    
    // Iterate through all lockers
    for (int i = 0; i < NUM_LOCKERS; i++) {
        if (strlen(lockers[i]) > 0) {
            printf("Locker %d: %s\n", i + 1, lockers[i]);
            rentedCount++;
        }
    }
    
    // Display message if no lockers are rented
    if (rentedCount == 0) {
        printf("No lockers are currently rented.\n");
    } else {
        printf("Total rented lockers: %d\n", rentedCount);
    }
    printf("======================\n\n");
}