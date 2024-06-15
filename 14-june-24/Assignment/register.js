// Calculate Age based on Date of Birth
document.getElementById('dob').addEventListener('blur', function() {
    const dob = new Date(this.value);
    const age = calculateAge(dob);
    document.getElementById('age').value = age;
});

function calculateAge(dob) {
    const diffMs = Date.now() - dob.getTime();
    const ageDt = new Date(diffMs);
    return Math.abs(ageDt.getUTCFullYear() - 1970);
}

function validateField(fieldId, errorId, validationFunc) {
    const field = document.getElementById(fieldId);
    const error = document.getElementById(errorId);
    const value = field.value.trim();

    const errorMessage = validationFunc(value);
    if (errorMessage) {
        error.textContent = errorMessage;
        field.classList.add('is-invalid');
        return false;
    } else {
        error.textContent = '';
        field.classList.remove('is-invalid');
        return true;
    }
}

// Validation functions for each field
function validateName(value) {
    return value === "" ? "Please enter your name." : "";
}

function validatePhone(value) {
    const phonePattern = /^\d{10}$/;
    return !phonePattern.test(value) ? "Please enter a valid 10-digit phone number." : "";
}

function validateDOB(value) {
    return value === "" ? "Please enter your date of birth." : "";
}

function validateEmail(value) {
    const emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return !emailPattern.test(value) ? "Please enter a valid email address." : "";
}

function validateGender() {
    const gender = document.querySelector('input[name="gender"]:checked');
    return gender ? "" : "Please select your gender.";
}

function validateQualification() {
    const qualifications = document.querySelectorAll('input[name="qualification"]:checked');
    return qualifications.length > 0 ? "" : "Please select at least one qualification.";
}

function validateProfession(value) {
    return value === "" ? "Please enter your profession." : "";
}

document.getElementById("name").addEventListener("blur", function() {
    validateField("name", "nameError", validateName);
});

document.getElementById("phone").addEventListener("blur", function() {
    validateField("phone", "phoneError", validatePhone);
});

document.getElementById("dob").addEventListener("blur", function() {
    validateField("dob", "dobError", validateDOB);
});

document.getElementById("email").addEventListener("blur", function() {
    validateField("email", "emailError", validateEmail);
});

document.querySelectorAll('input[name="gender"]').forEach(genderRadio => {
    genderRadio.addEventListener("blur", function() {
        validateField("gender", "genderError", validateGender);
    });
});

document.querySelectorAll('input[name="qualification"]').forEach(checkbox => {
    checkbox.addEventListener("blur", function() {
        validateField("qualification", "qualificationError", validateQualification);
    });
});

document.getElementById("profession").addEventListener("blur", function() {
    validateField("profession", "professionError", validateProfession);
});

function validateForm() {
    const isValidName = validateField("name", "nameError", validateName);
    const isValidPhone = validateField("phone", "phoneError", validatePhone);
    const isValidDOB = validateField("dob", "dobError", validateDOB);
    const isValidEmail = validateField("email", "emailError", validateEmail);
    const isValidGender = validateField("gender", "genderError", validateGender);
    const isValidQualification = validateField("qualification", "qualificationError", validateQualification);
    const isValidProfession = validateField("profession", "professionError", validateProfession);

    return isValidName && isValidPhone && isValidDOB && isValidEmail && isValidGender && isValidQualification && isValidProfession;
}

function handleSubmit(event) {
    event.preventDefault();

    if (validateForm()) {
        const name = document.getElementById('name').value;
        const phone = document.getElementById('phone').value;
        const dob = document.getElementById('dob').value;
        const age = document.getElementById('age').value;
        const email = document.getElementById('email').value;
        const gender = document.querySelector('input[name="gender"]:checked').value;
        const qualifications = Array.from(document.querySelectorAll('input[name="qualification"]:checked')).map(checkbox => checkbox.value);
        const profession = document.getElementById('profession').value;

        // Update profession datalist if a new profession is entered
        const professionDatalist = document.getElementById('professions');
        if (!Array.from(professionDatalist.options).map(option => option.value).includes(profession)) {
            const newOption = document.createElement('option');
            newOption.value = profession;
            professionDatalist.appendChild(newOption);
        }

        const newUser = { name, phone, dob, age, email, gender, qualifications, profession };

        const tableBody = document.getElementById('registrationTableBody');
        const newRow = document.createElement('tr');
        newRow.innerHTML = `
            <td>${newUser.name}</td>
            <td>${newUser.phone}</td>
            <td>${newUser.dob}</td>
            <td>${newUser.age}</td>
            <td>${newUser.email}</td>
            <td>${newUser.gender}</td>
            <td>${newUser.qualifications.join(", ")}</td>
            <td>${newUser.profession}</td>
        `;
        tableBody.appendChild(newRow);

        saveUserToLocalStorage(newUser);
        document.getElementById('registrationForm').reset();
        document.getElementById('age').value = "";
        document.getElementById("consolidatedErrors").textContent = "";
    } else {
        document.getElementById("consolidatedErrors").textContent = "Please correct the highlighted errors.";
    }
}

function saveUserToLocalStorage(user) {
    let users = JSON.parse(localStorage.getItem('users')) || [];
    users.push(user);
    localStorage.setItem('users', JSON.stringify(users));
}

// Load users from local storage on page load
document.addEventListener("DOMContentLoaded", function() {
    const users = JSON.parse(localStorage.getItem('users')) || [];
    const tableBody = document.getElementById('registrationTableBody');
    users.forEach(user => {
        const newRow = document.createElement('tr');
        newRow.innerHTML = `
            <td>${user.name}</td>
            <td>${user.phone}</td>
            <td>${user.dob}</td>
            <td>${user.age}</td>
            <td>${user.email}</td>
            <td>${user.gender}</td>
            <td>${user.qualifications.join(", ")}</td>
            <td>${user.profession}</td>
        `;
        tableBody.appendChild(newRow);
    });
});
