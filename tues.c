#include <stdio.h>

void increment(int *value) {
    (*value)++;
}
int main(void) {
    int count = 0;

    printf("Before increment: count = %d\n", count);
    increment(&count);
    printf("After increment: count = %d\n", count);

}