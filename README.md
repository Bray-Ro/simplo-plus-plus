# simplo++
A new programming language that is based on simplo but compiles into C. Written in c#
# documentation
# downloading and setup
To set up simplo++ first please download this repo and unzip it. Then you must download the following things:
. Mono c# compiler
.clang C compiler
Ok, now we have that out of the way lets get to setup. After you have downloaded the dependencies open the src folder in your text editor and then open a terminal. When you have a terminal open do this command: 
```
cd /Users/home/Downloads/src 
``` 
after you have executed this command go back into your text editor and go into the programs folder and open index.spp . This file should contain the following code:
```
define string language = "simplo"
;echo language
```
After the file has been opened delete the contents of it and change it to the following:
```
echo "hello world/n"
```
Then save the file and go back to the terminal and type the followning command:
```
mcs index.cs
```
then after that use this command: 
```
mono index.exe
```
Then use this command:
```
clang index.c
```
then use this:
```
./a.out
```
If you did everything right then you should get this output in the terminal:
```
hello world
```
# errors in the simplo++ compiler may happen
