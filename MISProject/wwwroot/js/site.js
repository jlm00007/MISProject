// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const weatherApi = {
    key: '4eb3703790b356562054106543b748b2',
    baseUrl: 'https://api.openweathermap.org/data/2.5/weather'
}

//anonymous function
//adding event listener key press of enter
let searchInputBox = document.getElementById('input-box');
searchInputBox.addEventListener('keypress', (event) => {
    if (event.keyCode == 13) {
        // console.log(searchInputBox.value);
        getWeatherReport(searchInputBox.value);

    }
})


//get waether report

function getWeatherReport(city) {
    fetch(`${weatherApi.baseUrl}?q=${city}&appid=${weatherApi.key}&units=imperial`)  // fetch method fetching the data from  base url ...metric is used for unit in celcius......here i am appending the base url to get data by city name .  
        .then(weather => {   //weather is from api
            return weather.json(); // return data from api in JSON
        }).then(showWeaterReport);  // calling showweatherreport function

}

//show weather report

function showWeaterReport(weather) {
    let city_code = weather.cod;
    if (city_code === '400') {
        swal("Empty Input", "Please enter any city", "error");
        reset();
    } else if (city_code === '404') {
        swal("Bad Input", "entered city didn't matched", "warning");
        reset();
    }
    else {

        // console.log(weather.cod);
        // console.log(weather);  
        let op = document.getElementById('weather-body');
        op.style.display = 'block';
        let todayDate = new Date();
        let parent = document.getElementById('parent');
        let weather_body = document.getElementById('weather-body');
        weather_body.innerHTML =
            `
    <div class="location-deatils">
        <div class="city" id="city">${weather.name}, ${weather.sys.country}</div>
        <div class="date" id="date"> ${dateManage(todayDate)}</div>
    </div>
    <div class="weather-status">
        <div class="temp" id="temp">${Math.round(weather.main.temp)}&deg;F </div>
        <div class="weather" id="weather"> ${weather.weather[0].main} <i class="${getIconClass(weather.weather[0].main)}"></i>  </div>
        <div class="min-max" id="min-max">${Math.floor(weather.main.temp_min)}&deg;F (min) / ${Math.ceil(weather.main.temp_max)}&deg;F (max) </div>
        <div id="updated_on">Updated as of ${getTime(todayDate)}</div>
    </div>
    <hr>
    <div class="day-details">
        <div class="basic">Feels like ${weather.main.feels_like}&deg;F | Humidity ${weather.main.humidity}%  <br> Pressure ${weather.main.pressure} mb | Wind ${weather.wind.speed} MPH</div>
    </div>
    `;
        parent.append(weather_body);
        changeBg(weather.weather[0].main);
        reset();
    }
}



//making a function for the  last update current time 

function getTime(todayDate) {
    let hour = addZero(todayDate.getHours());
    let minute = addZero(todayDate.getMinutes());
    return `${hour}:${minute}`;
}

//date manage for return  current date
function dateManage(dateArg) {
    let days = ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'];

    let months = ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'];

    let year = dateArg.getFullYear();
    let month = months[dateArg.getMonth()];
    let date = dateArg.getDate();
    let day = days[dateArg.getDay()];
    // console.log(year+" "+date+" "+day+" "+month);
    return `${date} ${month} (${day}) , ${year}`
}

// function for the dynamic background change  according to weather status
function changeBg(status) {
    if (status === 'Clouds') {
        document.body.style.backgroundImage = 'url(img/clouds.jpg)';
    } else if (status === 'Rain') {
        document.body.style.backgroundImage = 'url(img/rainy.jpg)';
    } else if (status === 'Clear') {
        document.body.style.backgroundImage = 'url(img/clear.jpg)';
    }
    else if (status === 'Snow') {
        document.body.style.backgroundImage = 'url(img/snow.jpg)';
    }
    else if (status === 'Sunny') {
        document.body.style.backgroundImage = 'url(img/sunny.jpg)';
    } else if (status === 'Thunderstorm') {
        document.body.style.backgroundImage = 'url(img/thunderstrom.jpg)';
    } else if (status === 'Drizzle') {
        document.body.style.backgroundImage = 'url(img/drizzle.jpg)';
    } else if (status === 'Mist' || status === 'Haze' || status === 'Fog') {
        document.body.style.backgroundImage = 'url(img/mist.jpg)';
    }

    else {
        document.body.style.backgroundImage = 'url(img/bg.jpg)';
    }
}

//making a function for the classname of icon
function getIconClass(classarg) {
    if (classarg === 'Rain') {
        return 'fas fa-cloud-showers-heavy';
    } else if (classarg === 'Clouds') {
        return 'fas fa-cloud';
    } else if (classarg === 'Clear') {
        return 'fas fa-cloud-sun';
    } else if (classarg === 'Snow') {
        return 'fas fa-snowman';
    } else if (classarg === 'Sunny') {
        return 'fas fa-sun';
    } else if (classarg === 'Mist') {
        return 'fas fa-smog';
    } else if (classarg === 'Thunderstorm' || classarg === 'Drizzle') {
        return 'fas fa-thunderstorm';
    } else {
        return 'fas fa-cloud-sun';
    }
}

function reset() {
    let input = document.getElementById('input-box');
    input.value = "";
}

// funtion to add zero if hour and minute less than 10
function addZero(i) {
    if (i < 10) {
        i = "0" + i;
    }
    return i;
}


async function displayPlayerPos(position) {
    const response = await fetch(`https://localhost:7270/api/Player/position/${position}`);
    const data = await response.json();
    const namesElement = document.getElementById('names');
    const numbersElement = document.getElementById('numbers');
    const positionsElement = document.getElementById('positions');
    // Clear previous data
    namesElement.innerHTML = '';
    numbersElement.innerHTML = '';
    positionsElement.innerHTML = '';
    data.forEach(player => {
        // Create new elements for each player
        const nameElement = document.createElement('div');
        nameElement.innerHTML = player.name;
        namesElement.appendChild(nameElement);
        const numberElement = document.createElement('div');
        numberElement.innerHTML = player.number;
        numbersElement.appendChild(numberElement);
        const positionElement = document.createElement('div');
        positionElement.innerHTML = player.position;
        positionsElement.appendChild(positionElement);
    });
    // Make elements visible
    namesElement.style.visibility = 'visible';
    numbersElement.style.visibility = 'visible';
    positionsElement.style.visibility = 'hidden';
} 



async function displayPlayers(teamID) {
    const response = await fetch(`https://localhost:7270/api/Player/getplayerdetails?TeamID=${teamID}`);
    const data = await response.json();
    const namesElement = document.getElementById('names');

    
    namesElement.innerHTML = '';

    data.forEach(player => {
       
        const playerDiv = document.createElement('div');

        
        playerDiv.textContent = `${player.name} ${player.number}`;

        
        namesElement.appendChild(playerDiv);
    });

  
    namesElement.style.visibility = 'visible';
}






async function displayPlayerStats(name) {
            // Get the hotel details from the server using a fetch request.
    const response = await fetch(`https://localhost:7270/api/Stat/${name}`)
            const data = await response.json();
            const hitsElement = document.getElementById('hits')
            const strikeoutsElement = document.getElementById('strikeouts');
            const homerunsElement = document.getElementById('homeruns');



                   hitsElement.innerHTML = data[0].hits + ", " + data[0].strikeouts + ", " + data[0].homeruns;
                     hitsElement.style.visibility = 'visible';
                     strikeoutsElement.style.visibility = 'visible';
                     homerunsElement.style.visibility = 'visible';

}



async function getPlayerStat(name) {
    const response = await fetch(`https://localhost:7270/api/Stat/${name}`);
    const data = await response.json();
    var innerHtml = '<h3>PLayers</h3><table class="table"><tr><th>name</th><th>hits</th><th>strikeouts</th><th>homeruns</th></tr>';
    for (let i = 0; i < data.length; i++) {
        innerHtml += `<tr><td>${data[i].name}</td><td>${data[i].hits}</td><td>${data[i].strikeouts}</td><td>${data[i].homeruns}</td></tr>`;
    }
    innerHtml += "</table>";
    document.getElementById('name').innerHTML = innerHtml;
    document.getElementById('name').style.visibility = 'visible';
}