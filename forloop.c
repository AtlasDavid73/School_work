#include <stdio.h>

int main() {
    char text[] = " led zeppelin";

    printf("Original: %s\n", text);
    printf("Uppercase: ");

    for (int i =0; text[i] != '\0'; i++) {
        if (text[i] >= 'a' && text[i] <= 'z') {
            printf("%c", text[i] - 32);
        }else{
            printf("%C", text[i]);
        }
    }
    printf("\n");
    return 0;
}