'use strict';
const url = '/odata/accounts';

var take = 20;
var sortField = 'Id'
var lastSort = '';
var currPage = 0;
var skip = 0;
function onSortBy(prop) {
    if (sortField == prop) {
        if (!lastSort.endsWith('desc'))
            prop += ' desc';
    }
    else
        sortField = prop;
    lastSort = prop;
    loadData(buildLink(url, take, prop, skip), callback);
}

function buildLink(url, take, sortField) {
    return url + '?$top=' + take + '&$orderBy=' + sortField + '&$skip=' + skip;
}

function loadData(query, callback) {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            callback(this.response);
        }
    };
    xhttp.open("GET", query, true);
    xhttp.send();
}

function rebuildView(values) {
    var generatedHtml = '';

    values.forEach(function (row) {
        generatedHtml += '<tr>';
        for (var prop in row) {
            generatedHtml += '<td>' + row[prop] + '</td>';
        }
        generatedHtml += '</tr>';
    });
    document.getElementById('tbody').innerHTML = generatedHtml;
}

function callback(response) {
    var parsed = JSON.parse(response);
    var values = parsed.value;
    rebuildView(values);
}

function onPage(idx) {
    currPage += idx;
    if (currPage < 0)
        currPage = 0;
    skip = currPage * take;
    loadData(buildLink(url, take, sortField, skip), callback);
}

(function () {
    loadData(buildLink(url, take, sortField, skip), callback);
})();