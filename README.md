# OOPCodes
In the Git Bash
cd ~
cd Desktop
git clone GitHub Repo Url( Create this Repo on the Github without a Readme file)
The current directory is the Desktop, so an empty Repo has been created/Cloned on your desktop with the same name as the empty GitHUb's Repo name.
Open it and copy paste in it the files you want to add to your Github's repo(suppose the repo name is codes)
On the Git Bash:
cd codes  (Now the current directory becomes the codes)
git status  (shows the status of the codes repo,that there are following untracked/unstaged files in this repo,that you have recently copied and pasted into it)
git add filename  OR   git add add -A  (would add those file into the Staged area)
git commit -m "commit msg"   (changes committed to the local repo codes)
Now,
git push origin master.
