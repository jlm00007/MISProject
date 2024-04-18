<details>

<summary>  MIS Project Part 2.1  </summary>

## Overview ##

This is a prototype build for my baseball climate website.  I hope to be able to add data so the viewer can select a team in the National League East and view how many wins they have when it's a certain temperature outside.  Its currently filled with dummy data that can be changed
as I learn to scrape or upload data to my website/code. Below is a breakdown of my current pages as of 2/6/2024.
## Research Findings ##
### Websites ###
[Baseball History](https://www.baseball-almanac.com/history/today.php?d=01-01)
- A very simple easily copiable website
- I would like to maybe implement its calendar function of just picking the day and it shows you everything that happened. 
- Also has the option to just select based on team
This website is very simple, although there are a lot of ads.  While it is very simple it has a huge database on baseball.  It can tell you stats about specific players or just a broad overview of the team.  It does not limit itself to just stats but gives a broader range of information such as “weird” baseball facts like a player being struck by lighting and finishing the game.  This website is made for baseball fans, not sports bettors.

[FanGraphs](https://www.fangraphs.com/)
- Has way more than just stats (blogs, news, other resources)
- Has a projections page to show potential future play and stats.  (could do to show how a team might play in certain weather, (wins/(wins+losses))
Aside from giving stats this website also gives future and prospective stats for current players.  It contains new articles and blog posts about current events, but it also contains a robust fantasy tool kit.  It analyzes player data and says if they should be drafted higher or lower if they have high potential and are sleeper pick.  This makes it very easy for fantasy users to scout players and better plan their draft.  This could be implemented on my website to give futures about teams and how they might play in certain weather conditions.  This website is slightly more complex but still easy to navigate.

[Baseball-Reference](https://www.baseball-reference.com/)
- Has a history of team records and other facts such as birthdays and death days
- The drop-down function allows you to pick specific stats you want to see from a team such as general averages for a season or specifically for batting or pitching
This website is like the other two in that it gives a plethora of information on many different players and teams.  The thing I specifically like and want to replicate is the drop down box to navigate and sort the data the user is trying to find.  Just like the travel website we are building by asking the user what they are trying to find at the very top of the website, it becomes very easy to navigate, and anyone can use it. 

### GitHub Repos ###
[Searchable Tables](https://github.com/key-lime-box/dynamic-table?tab=readme-ov-file)
This has not been implemented yet.  But I will be using it to make better tables for my teams so that people can querey out data and not have to scroll through a bunch of data.  This creates tables that can be sorted and filtered similar to Excel; it is written in java script.

[Weather Tracker](https://github.com/sachinprajapati8604/Weather_webApp/blob/main/index.html) <br>
This GitHub repo creates a useable weather tracker for a searched location.  I made changes to the look of it as well as converting it to Fahrenheit.  This is used to check the weather at the city the stadium is located.  It can be used to plan your day at the ballpark or to see what the weather is supposed to be so you can look at the team table and get a better understanding of how they might do.  With it not being limited to certain teams I am able to expand my website in the future to beyond the NL East.  


## Website Overview ##
### Home Page ###
  The first page the user sees when they navigate to my site is simple.  It's a jumping-off point to other parts of my website where the actual information is.  The home page lists every team in the NL East and allows you to navigate to the team page by clicking the team's name.  It also contains a weather bar that allows you to search a location to get weather data from, I am working on making it only show the 5 teams' stadium locations.
### Team Sites ###
  Each team's page is fundamentally the same with all the information being the same.  The page currently displays a table consisting of a date, win/loss, and the temperature.  Moving forward I hope to clean the data so that it's searchable rather than just all being on the page at once.
  I'd like the user to be able to  filter the data.  I attempted to make the websites more personable by adding the team's home stadium as the background of their page.
## Moving Forward ##
Moving forward I'd like to make the website look better and run smoother.  I want it to be able to run queries so a user can grab specific information they may need.  With these queries I'd like to be able to show the data in other ways such as counting the number of wins or losses at a certain temperature or showing
a specific date and whether the team won or lost and what the temperature was.  
Here is a quick checklist of what I hope to accomplish in the future:
- [ ] Make site data filterable
- [ ] Improve UI
- [ ] Add different functions to show different views of the data




## Sources ## 
[Calander Script](https://github.com/capjamesg/web-calendar/blob/main/webcalendar.js) <br>
[W3 Schools HTML](https://www.w3schools.com/html/default.asp) <br>
[W3 Schools CSS](https://www.w3schools.com/css/default.asp) <br>
[Markdown Guide](https://www.markdownguide.org/cheat-sheet/) <br>
Class Work <br>
[Stack Overflow](https://stackoverflow.com/) <br>

#### Reflection ####
The use of external sources has been critical in my success so far.  Without the ability to see others code on github or stack overflow many of the problems that I have couldnt be solved.  Github is very helpful in generating ideas and finding useful aspects you might want to add to your website, where as stack overflow is beneficial for troubleshooting errors or learning how to better do some aspects of code.  The most useful resource of all of them however, is W3 Schools. W3 helped establish an understanding of basic functions of CSS, HTML, and even JavaScript.  Its what allows me to learn and create more on my own without having to rely entirely on help from stack overflow or github.  I did not use Chat GPT during this assignment, but I am sure I will in the future. I beleive it will be beneficial to help think of ideas while aslo helping to fix some broken code; while its not perfect it might give me the push I need to figure it out on my own.  
</details>

***
<details>
<summary> MIS Project part 2.2 </summary>

## Merger Statement ##

We're creating a comprehensive application that seamlessly integrates weather analytics with team performance metrics. Whether it's understanding how temperature fluctuations impact batting averages or uncovering the influence of weather patterns on win-loss records, our application provides insight into the correlation between climate and baseball. Additionally, we go beyond the confines of the ballpark by offering users the ability to explore the temperature data of any city with a simple search feature. Whether you're planning on attending the game, or you are interested for fantasy purposes, our application is ideal for you.
</details>



***
# Climate Swing #

<details>
 <summary> Deployment Guide </summary>
 
  ### Database Deployment ###
  
  1. First import the database onto your machine from our [database github](https://github.com/jlm00007/BaseballDB) making sure to run the following code in order.
  2. Copy the [Database Creation](https://github.com/jlm00007/BaseballDB/blob/main/DatabaseCreation.sql) code and run it.
  3. Copy the [Database Data](https://github.com/jlm00007/BaseballDB/blob/main/DatabaseData.sql) code and run it.
  4. Grab each stored procedure from the Database GitHub home page (labeled with each person's name) making sure to run one stored procedure at a time.
 Once the Database is working properly with no errors move on to step two, setting up the website.
### Website and API Deployment ###
1. Now that the Database is working clone the repository with this [Github link](https://github.com/jlm00007/MISProject.git), the code should automatically link the Database and the website.
2. Once the code is in your machine go to the top of your screen where the start option is and hit the drop-down arrow
3. navigate to the configure startup projects and click on it.
4. Once it opens the popup menu select multiple startup projects and select to run both the MIS Project and the BaseballSiteAPI, this will allow the website to communicate to the API we have created.
5. Hit run and use the website as you wish. 
</details>
