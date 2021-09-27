#include <stdio.h>
#include <unistd.h>
#include <sys/types.h>
#include <stdlib.h>
#include <sys/wait.h>

int main(int argc, char **argv)
{
    int var = 7;
    pid_t pid;
    pid = fork(); // Aquí se crea el 1er hijo.
    if(pid > 0)
    {
        // Padre
        pid = fork(); // Se crea el 2do hijo.
        if (pid > 0)
            {printf("SOY EL PADRE ABUELO %d \n", getpid());}
        else
        {
            // Hijo 2
            var += 2;
            printf("VAR-9 %d hijo 2  %d del padre %d \n", var, getpid(), getppid());
            pid = fork(); //Se crea el 2do nieto.
            if (pid == 0)
                printf("VAR-9 %d nieto 2 %d del padre %d \n", var, getpid(), getppid());
            wait(NULL);
        }
    }
    else
    {
        // Hijo 1.
        // var++;
        printf("VAR-7 %d hijo 1  %d del padre %d \n", var, getpid(), getppid());
        pid = fork(); // Se crea el 1er nieto.
        if (pid > 0)
            var++;
        else
        {
            var++;
            printf("VAR-8 %d nieto 1 %d del padre %d \n", var, getpid(), getppid());
        }
        wait(NULL);
    }
    wait(NULL);
    exit(0);
}
