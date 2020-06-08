# FacebookLogin
Tasks : 
1) Login to facebook - fill email, password and then press enter (keyboard)
2) Click profile from options on left 
3) Click friends tab 
4) Check if the friends tab element is displayed on the current page using Assert methods

WorkFlow :
1) Opens up the browser
2) Go to the Url "http://facebook.com"
3) Maximize browser
4) Set implicit time wait ( which stays for entire session)
5) Finds the element with the Id "email" and fills "enter your email" there
6) Finds the element with the Id "pass" and fills "password" there and press Enter (keyboard)
7) Extract the profile element and click            
8) Extract the "Friends" tab and click 
9) Verify if the Friends tab is displayed on current page
10) Exception handling is also used
11) Closes the browser
12) Quits
