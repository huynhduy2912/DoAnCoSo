function loadProvinces() {
    fetch('/Address/GetProvinces')
        .then(response => response.json())
        .then(data => {
            var provinceSelect = document.getElementById('province');
            provinceSelect.innerHTML = '<option value="">Chọn tỉnh/thành phố</option>';
            data.forEach(function (province) {
                var option = document.createElement('option');
                option.value = province.code;
                option.textContent = province.name_with_type;
                provinceSelect.appendChild(option);
            });
        });
}
function loadDistricts(provinceId) {
    loadWards(-1);
    fetch('/Address/GetDistricts?provinceId=' + provinceId)
        .then(response => response.json())
        .then(data => {
            var districtSelect = document.getElementById('district');
            districtSelect.innerHTML = '<option value="">Chọn quận/huyện</option>';
            data.forEach(function (district) {
                var option = document.createElement('option');
                option.value = district.code;
                option.textContent = district.name_with_type;
                districtSelect.appendChild(option);
            });
        });
}

function loadWards(districtId) {
    fetch('/Address/GetWards?districtId=' + districtId)
        .then(response => response.json())
        .then(data => {
            var wardSelect = document.getElementById('ward');
            wardSelect.innerHTML = '<option value="">Chọn xã/phường</option>';
            data.forEach(function (ward) {
                var option = document.createElement('option');
                option.value = ward.path_with_type;
                option.textContent = ward.name_with_type;
                wardSelect.appendChild(option);
            });
        });
}
function updateInput() {
    var selectElement = document.getElementById("ward");
    var inputElement = document.getElementById("address");
    inputElement.value = selectElement.value;
}
loadProvinces();
