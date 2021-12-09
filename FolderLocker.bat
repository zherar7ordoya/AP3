rem https://www.laptopmag.com/articles/password-protect-folder-windows-10

cls
@echo off
title Folder Locker

    if      exist "Control Panel.{21EC2020-3AEA-1069-A2DD-08002B30309D}" goto UNLOCK
    if      not exist Locker goto MDLOCKER

:CONFIRM
    echo    Are you sure that you want the lock folder? (Y/N)
    set/p   "cho=>"
    if      %cho%==Y goto LOCK
    if      %cho%==y goto LOCK
    if      %cho%==N goto END
    if      %cho%==n goto END
    echo    Sorry, invalid choice
    goto    CONFIRM

:LOCK
    ren     Locker "Control Panel.{21EC2020-3AEA-1069-A2DD-08002B30309D}"
    attrib  +h +s "Control Panel.{21EC2020-3AEA-1069-A2DD-08002B30309D}"
    echo    Folder locked
    goto    END

:UNLOCK
    echo    Please, enter the password
    set/p   "pass=>"
    if      NOT %pass%==secret goto FAIL
    attrib  -h -s "Control Panel.{21EC2020-3AEA-1069-A2DD-08002B30309D}"
    ren     "Control Panel.{21EC2020-3AEA-1069-A2DD-08002B30309D}" Locker
    echo    Folder unlocked
    cd      Locker
    goto    END

:FAIL
    echo    Invalid password
    goto    END

:MDLOCKER
    md      Locker
    echo    Folder «Locker» successfully created.
    goto    END

:END