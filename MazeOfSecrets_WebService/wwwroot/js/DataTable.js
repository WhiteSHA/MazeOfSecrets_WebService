﻿var requestOptions = {
    method: 'GET',
    redirect: 'follow'
};

fetch("http://localhost:63489/api/MazeDataItems", requestOptions)
    .then(response => response.text())
    .then(result => doResultProcess(result))
    .catch(error => console.log('error', error));

function doResultProcess(res) {
    var jsonData = JSON.parse(res);

    console.log(jsonData);
    console.log(jsonData.length);

    CreateTable(jsonData);
}

function CreateTable(jsonData) {
    var body = document.getElementsByTagName('body')[0];
    var tbl = document.createElement('table');
    tbl.setAttribute('id', 'dataTable');
    var thead = document.createElement('thead');

    var tr = document.createElement('tr');
    tr.setAttribute('id', 'tableMainHeader');

    var th = document.createElement('th');
    th.innerHTML = "ID";
    th.appendChild(document.createTextNode('\u0020'))
    tr.appendChild(th)

    th = document.createElement('th');
    th.innerHTML = "User ID";
    th.appendChild(document.createTextNode('\u0020'))
    tr.appendChild(th)

    th = document.createElement('th');
    th.innerHTML = "Question";
    th.appendChild(document.createTextNode('\u0020'))
    tr.appendChild(th)

    th = document.createElement('th');
    th.innerHTML = "Correct Answer";
    th.appendChild(document.createTextNode('\u0020'))
    tr.appendChild(th)

    th = document.createElement('th');
    th.innerHTML = "Wrong Answer 1";
    th.appendChild(document.createTextNode('\u0020'))
    tr.appendChild(th)

    th = document.createElement('th');
    th.innerHTML = "Wrong Answer 2";
    th.appendChild(document.createTextNode('\u0020'))
    tr.appendChild(th)

    thead.appendChild(tr);

    var tbdy = document.createElement('tbody');

    for (var i = 0; i < jsonData.length; i++) {
        var tr = document.createElement('tr');

        var th = document.createElement('th');
        th.innerHTML = jsonData[i].id;
        th.style.textAlign = 'center';
        th.appendChild(document.createTextNode('\u0020'))
        tr.appendChild(th)

        th = document.createElement('td');
        th.innerHTML = jsonData[i].userId;
        th.appendChild(document.createTextNode('\u0020'))
        tr.appendChild(th)

        th = document.createElement('td');
        th.innerHTML = jsonData[i].question;
        th.appendChild(document.createTextNode('\u0020'))
        tr.appendChild(th)

        th = document.createElement('td');
        th.innerHTML = jsonData[i].correctAnswer;
        th.appendChild(document.createTextNode('\u0020'))
        tr.appendChild(th)

        th = document.createElement('td');
        th.innerHTML = jsonData[i].wrongAnswer1;
        th.appendChild(document.createTextNode('\u0020'))
        tr.appendChild(th)

        th = document.createElement('td');
        th.innerHTML = jsonData[i].wrongAnswer2;
        th.appendChild(document.createTextNode('\u0020'))
        tr.appendChild(th)

        tbdy.appendChild(tr);
    }
    tbl.appendChild(thead);
    tbl.appendChild(tbdy);
    body.appendChild(tbl);

    SetTableStyles();

    document.getElementById("waitingLabel").innerHTML = "";
}

function SetTableStyles() {
    var table = document.getElementById("dataTable");
}