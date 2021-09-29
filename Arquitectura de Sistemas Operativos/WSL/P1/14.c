#include <stdio.h>
#include <unistd.h>
#include <sys/types.h>
#include <stdlib.h>
#include <sys/wait.h>

int main(int argc, char **argv)
{
    int var = 5;
    pid_t pid;
    pid = fork();

    if (pid == 0)
    {
        printf("\n");
        printf("Hijo: Soy el proceso hijo.\n");
        printf("Hijo: Recibo variable en %d \n", var);
        printf("Hijo: Restando 1 a la variable... \n");
        var--;
        printf("Hijo: Ahora variable está en %d \n", var);
}

var++;

if (pid > 0)
{
    printf("\n");
    printf("Padre: Soy el proceso padre.\n");
    printf("Padre: Recibo variable en %d \n", var);
    printf("Padre: Sumando 1 a la variable... \n");
    var++;
    printf("Padre: Ahora variable está en %d \n", var);
}
    exit(0);
}
