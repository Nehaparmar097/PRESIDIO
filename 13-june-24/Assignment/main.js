

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
function validateProductId(value) {
    if (value === "") return "Please enter a Product ID.";
    if (isNaN(value) || parseInt(value) <= 0) return "Product ID must be a positive integer.";
    
    return "";
}

function validateProductName(value) {
    if (value === "") return "Please enter a Product Name.";
    return "";
}

function validateProductPrice(value) {
    if (value === "") return "Please enter a Product Price.";
    if (isNaN(value) || parseFloat(value) <= 0) return "Product Price must be a positive number.";
    return "";
}

function validateProductQuantity(value) {
    if (value === "") return "Please enter a Product Quantity.";
    if (isNaN(value) || parseInt(value) < 0) return "Product Quantity must be a non-negative integer.";
    return "";
}

// Attach dynamic validation to inputs
document.getElementById("productId").addEventListener("input", function() {
    validateField("productId", "productIdError", validateProductId);
});

document.getElementById("productName").addEventListener("input", function() {
    validateField("productName", "productNameError", validateProductName);
});

document.getElementById("productPrice").addEventListener("input", function() {
    validateField("productPrice", "productPriceError", validateProductPrice);
});

document.getElementById("productQuantity").addEventListener("input", function() {
    validateField("productQuantity", "productQuantityError", validateProductQuantity);
});

// Function to validate the form
function validateForm() {
    const isValidId = validateField("productId", "productIdError", validateProductId);
    const isValidName = validateField("productName", "productNameError", validateProductName);
    const isValidPrice = validateField("productPrice", "productPriceError", validateProductPrice);
    const isValidQuantity = validateField("productQuantity", "productQuantityError", validateProductQuantity);

    return isValidId && isValidName && isValidPrice && isValidQuantity;
}


// Function to handle adding the product
function addProduct(event) {
    event.preventDefault(); // Prevent form submission

    if (validateForm()) {
        const id = document.getElementById('productId').value;
        const name = document.getElementById('productName').value;
        const price = document.getElementById('productPrice').value;
        const quantity = document.getElementById('productQuantity').value;

        const newProduct = { id, name, price, quantity };

        const newRow = document.createElement('tr');
        newRow.innerHTML = `
            <td>${newProduct.id}</td>
            <td>${newProduct.name}</td>
            <td>$${parseFloat(newProduct.price).toFixed(2)}</td>
            <td>${newProduct.quantity}</td>
        `;

        const tableBody = document.getElementById('productTableBody');
        tableBody.appendChild(newRow);

        saveProductToLocalStorage(newProduct);
        document.getElementById('productForm').reset();
    }
}

// Function to save the product to local storage
function saveProductToLocalStorage(product) {
    let products = JSON.parse(localStorage.getItem('products')) || [];
    products.push(product);
    localStorage.setItem('products', JSON.stringify(products));
}