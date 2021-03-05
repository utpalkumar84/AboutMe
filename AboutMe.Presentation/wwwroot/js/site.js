const uri = 'https://localhost:44398/api/AboutMe';

function getItems() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayItems(data))
        .catch(error => console.error('Unable to get items.', error));
}

function _displayItems(data) {
    const tBody = document.getElementById('myinfo');
    tBody.innerHTML = '';

    let trName = tBody.insertRow();

    let tdName = trName.insertCell(0);
    let nameNode = document.createTextNode('Name');
    tdName.appendChild(nameNode);

    let tdNameValue = trName.insertCell(1);
    let nameValueNode = document.createTextNode(data.name);
    tdNameValue.appendChild(nameValueNode);

    let trProfile = tBody.insertRow();

    let tdProfile = trProfile.insertCell(0);
    let profileNode = document.createTextNode('Profile');
    tdProfile.appendChild(profileNode);

    let tdProfileValue = trProfile.insertCell(1);
    let profileValueNode = document.createTextNode(data.profile);
    tdProfileValue.appendChild(profileValueNode);
}