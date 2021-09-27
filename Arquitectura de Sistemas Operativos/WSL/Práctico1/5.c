#include <stdio.h>
#include <unistd.h>
#include <sys/types.h>
#include <stdlib.h>

int main()
{
    int pid;
    pid = getpid();

    printf("\nID del presente proceso: %d\n", pid);
    printf("\n[ Clonación... ] \n");

    // Crear proceso hijo, Recuperar PID del hijo
    pid = fork();
    if (pid < 0)
    {
        // Falla durante el clonado.
        exit(-1);
    }
    else if(pid == 0)
    {
        // Proceso hijo.
        printf("\nEl proceso hijo está durmiendo...\n");
        sleep(5);

        // El ID del padre del huérfano es 1.
        printf("\nID del padre del huérfano: %d\n", getppid());
    }
    else
    {
        // Proceso padre.
        printf("\nPROCESO PADRE COMPLETADO\n");
        system("ps -l");
    }
    return 0;
}

/* Output

[divyen@localhost PP-TW1]$ ./Prog01-O &
[1] 2277
Current Process ID is : 2277
[ Forking Child Process ... ]
Parent Process Completed ...[divyen@localhost PP-TW1]$ ps -l
F S   UID   PID  PPID  C PRI  NI ADDR    SZ WCHAN  TTY          TIME CMD
0 S   500  2193  2192  0  75   0    -  1078 wait4  pts/2    00:00:00 bash
1 S   500  2278     1  0  75   0    -   336 schedu pts/2    00:00:00 Prog01-O
0 R   500  2279  2193  0  81   0    -   787 -      pts/2    00:00:00 ps
[1]+  Done                    ./Prog01-O
[divyen@localhost PP-TW1]$ Child Process is Sleeping ...
Orphan Child's Parent ID : 1

*/