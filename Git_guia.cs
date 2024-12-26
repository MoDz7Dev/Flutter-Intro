
//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo
$ dir
Flutter

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo
$ cd /Flutter
bash: cd: /Flutter: No such file or directory

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo
$ cd Flutter

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter
$ dir
01-dart.intro

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter
$ cd 01-dart.intro/

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro
$ git init
Initialized empty Git repository in E:/Codigo/.
git/

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (master)
$ git status
On branch master

No commits yet

Untracked files:
  (use "git add <file>..." to include in what will be committed)
        01_hello_world.dart
        02_variables.dart
        03_maps.dart
        04_list_iterable.dart
        05_functions_and_parameters.dart
        06_classes.dart

nothing added to commit but untracked files present (use "git add" to track)

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (master)
$ git add .

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (master)
$ git status
On branch master

No commits yet

Changes to be committed:
  (use "git rm --cached <file>..." to unstage)
        new file:   01_hello_world.dart
        new file:   02_variables.dart
        new file:   03_maps.dart
        new file:   04_list_iterable.dart
        new file:   05_functions_and_parameters.dart
        new file:   06_classes.dart


//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (master)
$ git commit
Author identity unknown

*** Please tell me who you are.

Run

  git config --global user.email "you@example.com"
  git config --global user.name "Your Name"

to set your account's default identity.
Omit --global to set the identity only in this repository.

fatal: unable to auto-detect email address (got 'modz7@DESKTOP-DIFKDFO.(none)')

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (master)
$ git commit -m "Primer commit"
Author identity unknown

*** Please tell me who you are.

Run

  git config --global user.email "you@example.com"
  git config --global user.name "Your Name"

to set your account's default identity.
Omit --global to set the identity only in this repository.

fatal: unable to auto-detect email address (got 'modz7@DESKTOP-DIFKDFO.(none)')

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (master)
$ git config --global user.email "modz7dev@gmail.com"

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (master)
$ git config --global user.name "Javier Arancibia"

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (master)
$ git status
On branch master

No commits yet

Changes to be committed:
  (use "git rm --cached <file>..." to unstage)
        new file:   01_hello_world.dart
        new file:   02_variables.dart
        new file:   03_maps.dart
        new file:   04_list_iterable.dart
        new file:   05_functions_and_parameters.dart
        new file:   06_classes.dart


//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (master)
$ git commit -m "Primer Commit"
[master (root-commit) decf883] Primer Commit
 6 files changed, 128 insertions(+)
 create mode 100644 01_hello_world.dart
 create mode 100644 02_variables.dart
 create mode 100644 03_maps.dart
 create mode 100644 04_list_iterable.dart
 create mode 100644 05_functions_and_parameters.dart
 create mode 100644 06_classes.dart

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (master)
$ git status
On branch master
nothing to commit, working tree clean

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (master)
$ git remote add origin https://github.com/MoDz7Dev/Flutter-Intro.git

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (master)
$ git push -u origin master
info: please complete authentication in your browser...
Enumerating objects: 8, done.
Counting objects: 100% (8/8), done.
Delta compression using up to 4 threads
Compressing objects: 100% (7/7), done.
Writing objects: 100% (8/8), 1.91 KiB | 976.00 KiB/s, done.
Total 8 (delta 0), reused 0 (delta 0), pack-reused 0 (from 0)
To https://github.com/MoDz7Dev/Flutter-Intro.git
 * [new branch]      master -> master
branch 'master' set up to track 'origin/master'.

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (master)
$ git status
On branch master
Your branch is up to date with 'origin/master'.

nothing to commit, working tree clean

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (master)
$ ^C

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (master)
$ git push -u origin master
branch 'master' set up to track 'origin/master'.
Everything up-to-date

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (master)
$ git status
On branch master
Your branch is up to date with 'origin/master'.

nothing to commit, working tree clean

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (master)
$ git status
On branch master
Your branch is up to date with 'origin/master'.

Changes not staged for commit:
  (use "git add <file>..." to update what will be committed)
  (use "git restore <file>..." to discard changes in working directory)
        modified:   01_hello_world.dart

no changes added to commit (use "git add" and/or "git commit -a")

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (master)
$ git add .

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (master)
$ git status
On branch master
Your branch is up to date with 'origin/master'.

Changes to be committed:
  (use "git restore --staged <file>..." to unstage)
        modified:   01_hello_world.dart


//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (master)
$ git commit -m "Modificacion en "01_hello_world.dart""
[master 732596b] Modificacion en 01_hello_world.dart
 1 file changed, 1 insertion(+)

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (master)
$ git status
On branch master
Your branch is ahead of 'origin/master' by 1 commit.
  (use "git push" to publish your local commits)

nothing to commit, working tree clean

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (master)
$ git push
Enumerating objects: 5, done.
Counting objects: 100% (5/5), done.
Delta compression using up to 4 threads
Compressing objects: 100% (2/2), done.
Writing objects: 100% (3/3), 291 bytes | 291.00 KiB/s, done.
Total 3 (delta 1), reused 0 (delta 0), pack-reused 0 (from 0)
remote: Resolving deltas: 100% (1/1), completed with 1 local object.
To https://github.com/MoDz7Dev/Flutter-Intro.git
   decf883..732596b  master -> master

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (master)
$ git status
On branch master
Your branch is up to date with 'origin/master'.

nothing to commit, working tree clean

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (master)
$ git checkout -b Rama_2
Switched to a new branch 'Rama_2'

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (Rama_2)
$ git status
On branch Rama_2
nothing to commit, working tree clean

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (Rama_2)
$ git status
On branch Rama_2
Changes not staged for commit:
  (use "git add <file>..." to update what will be committed)
  (use "git restore <file>..." to discard changes in working directory)
        modified:   01_hello_world.dart

no changes added to commit (use "git add" and/or "git commit -a")

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (Rama_2)
$ git add .

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (Rama_2)
$ git status
On branch Rama_2
Changes to be committed:
  (use "git restore --staged <file>..." to unstage)
        modified:   01_hello_world.dart


///modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (Rama_2)
$ git commit -m "Demostracion de ramas"
[Rama_2 b2a6ab6] Demostracion de ramas
 1 file changed, 2 insertions(+), 1 deletion(-)

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (Rama_2)
$ git push
fatal: The current branch Rama_2 has no upstream branch.
To push the current branch and set the remote as upstream, use

    git push --set-upstream origin Rama_2

To have this happen automatically for branches without a tracking
upstream, see 'push.autoSetupRemote' in 'git help config'.


//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (Rama_2)
$ git push --set-upstream origin Rama_2
Enumerating objects: 5, done.
Counting objects: 100% (5/5), done.
Delta compression using up to 4 threads
Compressing objects: 100% (2/2), done.
Writing objects: 100% (3/3), 292 bytes | 292.00 KiB/s, done.
Total 3 (delta 1), reused 0 (delta 0), pack-reused 0 (from 0)
remote: Resolving deltas: 100% (1/1), completed with 1 local object.
remote:
remote: Create a pull request for 'Rama_2' on GitHub by visiting:
remote:      https://github.com/MoDz7Dev/Flutter-Intro/pull/new/Rama_2
remote:
To https://github.com/MoDz7Dev/Flutter-Intro.git
 * [new branch]      Rama_2 -> Rama_2
branch 'Rama_2' set up to track 'origin/Rama_2'.

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (Rama_2)
$ git status
On branch Rama_2
Your branch is up to date with 'origin/Rama_2'.

nothing to commit, working tree clean

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (Rama_2)
$ git checkout master
Switched to branch 'master'
Your branch is up to date with 'origin/master'.

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (master)
$ ^C

//modz7@DESKTOP-DIFKDFO MINGW64 /e/Codigo/Flutter/01-dart.intro (master)
$ 
