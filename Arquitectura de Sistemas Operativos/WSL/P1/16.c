#include <stdio.h>
#include <unistd.h>
#include <sys/types.h>
#include <stdlib.h>
#include <sys/wait.h>

int main(void)
{

    pid_t pid;
    pid_t id1 = fork();
    pid_t id2 = fork();

    if (id1 > 0 && id2 > 0)
    {
        wait(NULL);
        wait(NULL);
        printf("\nPADRE FINALIZADO \n");
        printf("ID proceso padre:  %d \n", getppid());
        printf("ID proceso actual: %d \n", getpid());
        printf("ID proceso hijo:   %d \n", pid);
    }
    else if (id1 == 0 && id2 > 0)
    {
        pid = id2;
        sleep(2);
        wait(NULL);
        printf("\nHIJO FINALIZADO \n");
        printf("ID proceso padre:  %d \n", getppid());
        printf("ID proceso actual: %d \n", getpid());
        printf("ID proceso hijo:   %d \n", pid);
    }
    else if (id1 > 0 && id2 == 0)
    {
        pid = id1;
        sleep(1);
        printf("\nNIETO FINALIZADO \n");
        printf("ID proceso padre:  %d \n", getppid());
        printf("ID proceso actual: %d \n", getpid());
        printf("ID proceso hijo:   %d \n", pid);
    }
    else
    {
        printf("\nBISNIETO FINALIZADO\n");
        printf("ID proceso padre:  %d \n", getppid());
        printf("ID proceso actual: %d \n", getpid());
        printf("ID proceso hijo:   %d \n", pid);
    }
    exit(0);
}