# MIS Project Part 2 #
## Overview ##
This is a prototype build for my baseball climate website.  I hope to be able to add data so the viewer can select a team in the National League East and view how many wins they have when its a certain tempature outside.  Its currently filled with dummy data that can be changed
as I learn to scrape or upload data to my website/code. Below is a breakdown of my current pages as of 2/6/2024.
## Research Findings ##
### Websites ###
[Baseball History](https://www.baseball-almanac.com/history/today.php?d=01-01)
- A very simple easily copiable website
- I would like to maybe implement its calendar function on just picking the day and it shows you everything that happened. 
- Also has the option to just select based on team
This website is very simple, although there are a lot of ads.  While it is very simple it has a huge database on baseball.  It can tell you stats about specific players or just a broad overview of the team.  It does not limit itself to just stats, but gives a broader range of information such as “weird” baseball facts like a player being struck by lighting and finishing the game.  This website is made for baseball fans, not sports bettors.

[FanGraphs](https://www.fangraphs.com/)
- Has way more than just stats (blogs,news,other resources)
- Has a projections page to show potential future play and stats.  (could do to show how a team might play in certain weather, (wins/(wins+losses))
Aside from giving stats this website also gives futures and prospective stats for current players.  It contains new articles and blog posts about current events, but it also contains a robust fantasy tool kit.  It analyzes player data and says if they should be drafted higher or lower, if they have high potential and are a sleeper pick.  This makes it very easy for fantasy users to scout players and better plan their draft.  This could be implemented on my website to give futures about teams and how they might play in certain weather conditions.  This website is slightly more complex but still easy to navigate.

[Baseball-Reference](https://www.baseball-reference.com/)
- Has history of teams records and other facts such as birthdays and death days
- The drop down function allows you to pick specific stats you want to see from a team such as general averages for a season or specifically for batting or pitching
This website is like the other two in that it gives a plethora of information on many different players and teams.  The thing I specifically like and want to replicate is the drop down box to navigate and sort the data the user is trying to find.  Just like the travel website we are building by asking the user what they are trying to find at the very top of the website it becomes veery easy to navigate, and anyone can use it. 

### GitHub Repos ###


## Website Overview ##
### Home Page ###
  The first page the user sees when they navigate to my site is simple.  Its a jumping off point to other parts of my website where the actual information is.  The home page lists every team in the NL East and allows you to navigate to the team page by clicking the teams name.
### Team Sites ###
  Each teams page is fundamnetally the same with all the information being the same.  The page currently displays a table consisting of a date, win/loss, and the tempature.  Moving forward I hope to clean the data so that its searchable rather than just all being on the page at once.
  Id like the user to be able to  filter the data.  I attempted to make the websites more personable by adding the teams home stadium as the background of their page.
## Moving Forward ##
Moving forward I'd like to make the website look better and run smoother.  I want it to be able to run queries so a user can grab specific information they may need.  With these queries Id like to be able to show the data in other ways such as counting the number of wins or losses at a certain tempature or showing
a specific date and weather the team won or lost and what the temperature was.  
Here is a quick checklist with what I hope to accomplish in the future:
- [ ] Make site data filterable
- [ ] Improve UI
- [ ] Add diffrent fucntions to show diffrent views of the data




## Sources ## 
[Calander Script](https://github.com/capjamesg/web-calendar/blob/main/webcalendar.js)
[W3 Schools HTML](https://www.w3schools.com/html/default.asp)
[W3 Schools CSS](https://www.w3schools.com/css/default.asp)
Class Work 
