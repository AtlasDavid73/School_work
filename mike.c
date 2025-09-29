#include <stdio.h> 
#define max_websites 3 
#define max_visitors 20 

int main () {
    int num_websites = max_websites;
    char website_names[max_websites][50] = {"website 1", "website 2", "website 3"};
    int num_visitors[max_websites];

    // input number of visitors for each website.
    for (int website_idx = 0; website_idx < num_websites; website_idx++) {
        printf("enter the number of visitors for %s (max %d): ", website_names[website_idx], max_visitors);
        scanf("%d", &num_visitors[website_idx]);
    }

    // create vla to store visitor ages for each website.
    int visitor_ages[max_websites][max_visitors];

    // input visitor ages for each website.
    for (int website_idx = 0; website_idx < num_websites; website_idx++) {
        printf("enter the ages of visitors for %s (range 15-75):\n", website_names[website_idx]);
        for (int visitor_idx = 0; visitor_idx < num_visitors[website_idx]; visitor_idx++) {
            scanf("%d", &visitor_ages[website_idx][visitor_idx]);
        }
    }

    // calculate mean age for each website.
    float mean_ages[max_websites];
    for (int website_idx = 0; website_idx < num_websites; website_idx++) {
        int sum_ages = 0;
        for (int visitor_idx = 0; visitor_idx < num_visitors[website_idx]; visitor_idx++) {
            sum_ages += visitor_ages[website_idx][visitor_idx];
        }
        mean_ages[website_idx] = (float)sum_ages / num_visitors[website_idx];
    }

    // print the results
    printf("\nwebsite traffic analysis:\n");
    for (int website_idx = 0; website_idx < num_websites; website_idx++) {
        printf("website: %s\n", website_names[website_idx]);
        printf("number of visitors: %d\n", num_visitors[website_idx]);
        printf("mean age of visitors: %.2f\n\n", mean_ages[website_idx]);
    }
    
    return 0;
}
