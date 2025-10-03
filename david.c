#include <stdio.h>

int main () {
    char text[] = "David";

    for (int i =0; text[i] != '\0'; i++) {
        for (int j =0; j < i; j++) {
            printf("");
        }
        for (int j = 0; j <= i; j++) {
            printf("%c", text[j]);
        }
        printf("\n");
    }
return 0;
}
