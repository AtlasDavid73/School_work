#include <stdio.h>

int main() {
    float prices[] = {15.99f, 22.50f, 10.25f};
    int num_items = sizeof(prices) / sizeof(prices[0]);

    // Apply a discount to each price
    for (int i = 0; i < num_items; i++) {
        prices[i] = prices[i] * 0.90f; // 10% discount
    }

    printf("Discounted prices:\n");
    for (int i = 0; i < num_items; i++) {
        printf("Item %d: %.2f\n", i + 1, prices[i]);
    }

    return 0;
}