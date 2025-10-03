#include <stdio.h>

// Function to add two double-precision floating-point numbers
double add_doubles(double a, double b) {
    return a + b;
}

// Function to calculate the average of a float array
float calculate_average(float arr[], int size) {
    float sum = 0.0f;
    for (int i = 0; i < size; i++) {
        sum += arr[i];
    }
    return sum / size;
}

int main() {
    double num1 = 10.5;
    double num2 = 20.3;
    double sum_result = add_doubles(num1, num2);
    printf("Sum of doubles: %.2f\n", sum_result); // Output: 30.80

    float my_floats[] = {1.1f, 2.2f, 3.3f, 4.4f};
    int array_size = sizeof(my_floats) / sizeof(my_floats[0]);
    float average_result = calculate_average(my_floats, array_size);
    printf("Average of float array: %.2f\n", average_result); // Output: 2.75

    return 0;
}