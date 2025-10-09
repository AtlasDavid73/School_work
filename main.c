#include <stdio.h>
#include <string.h>
#include "locker_rental_system.h"

void displayMenu() {
    printf("\n========== Locker Rental System ==========\n");
    printf("1. View a locker\n");
    printf("2. Rent a locker\n");
    printf("3. End a locker rental\n");
    printf("4. List all locker contents\n");
    printf("5. Quit\n");
    printf("==========================================\n");
    printf("Enter your choice: ");
}

int main() {
    // Initialize
    char lockers[MAX_LOCKERS][MAX_ITEM_LENGTH];
    
    // all lockers to empty strings
    for (int i = 0; i < MAX_LOCKERS; i++) {
        lockers[i][0] = '\0';
    }
    
    int choice;
    int lockerNumber;
    char item[MAX_ITEM_LENGTH];
    
    printf("Welcome to the Locker Rental System!\n");
    printf("We have %d lockers available for rent.\n", MAX_LOCKERS);
    
    // Main program loop
    while (1) {
        displayMenu();
        
        // Get user choice
        if (scanf("%d", &choice) != 1) {
            // Clear invalid input
            while (getchar() != '\n');
            printf("Error: Invalid input. Please enter a number between 1 and 5.\n");
            continue;
        }
        
        // Clear input buffer
        while (getchar() != '\n');
        
        // Handle menu options using switch statement
        switch (choice) {
            case 1: // View a locker
                printf("Enter locker number (1-%d): ", MAX_LOCKERS);
                if (scanf("%d", &lockerNumber) != 1) {
                    while (getchar() != '\n');
                    printf("Error: Invalid input. Please enter a valid locker number.\n");
                    break;
                }
                while (getchar() != '\n');
                viewLocker(lockers, lockerNumber);
                break;
                
            case 2: // Rent a locker
                printf("Enter locker number to rent (1-%d): ", MAX_LOCKERS);
                if (scanf("%d", &lockerNumber) != 1) {
                    while (getchar() != '\n');
                    printf("Error: Invalid input. Please enter a valid locker number.\n");
                    break;
                }
                while (getchar() != '\n');
                
                printf("Enter item to store: ");
                if (fgets(item, MAX_ITEM_LENGTH, stdin) != NULL) {
                    
                    size_t len = strlen(item);
                    if (len > 0 && item[len - 1] == '\n') {
                        item[len - 1] = '\0';
                    }
                    
                    if (strlen(item) == 0) {
                        printf("Error: Item description cannot be empty.\n");
                    } else {
                        rentLocker(lockers, lockerNumber, item);
                    }
                } else {
                    printf("Error: Failed to read item description.\n");
                }
                break;
                
            case 3: // End a locker rental
                printf("Enter locker number to end rental (1-%d): ", MAX_LOCKERS);
                if (scanf("%d", &lockerNumber) != 1) {
                    while (getchar() != '\n');
                    printf("Error: Invalid input. Please enter a valid locker number.\n");
                    break;
                }
                while (getchar() != '\n');
                endRental(lockers, lockerNumber);
                break;
                
            case 4: // List all locker contents
                listLockerContents(lockers);
                break;
                
            case 5: // Quit
                printf("\nThank you for using the Locker Rental System. Goodbye!\n");
                return 0;
                
            default:
                printf("Error: Invalid choice. Please enter a number between 1 and 5.\n");
                break;
        }
    }
    
    return 0;
}