import re
import datetime
from openpyxl import Workbook
from fpdf import FPDF
import pandas as pd


def calculate_age(dob):
    today = datetime.date.today()
    dob = datetime.datetime.strptime(dob, "%Y-%m-%d").date()
    return today.year - dob.year - ((today.month, today.day) < (dob.month, dob.day))


def is_valid_email(email):
    return re.match(r"[^@]+@[^@]+\.[^@]+", email) is not None


def is_valid_phone(phone):
    return re.match(r"\d{10}", phone) is not None


def get_employee_details():
    while True:
        name = input("Enter Name: ")
        dob = input("Enter DOB (YYYY-MM-DD): ")
        phone = input("Enter Phone Number: ")
        email = input("Enter Email: ")

        try:
            dob_obj = datetime.datetime.strptime(dob, "%Y-%m-%d")
        except ValueError:
            print("Invalid DOB format. Please use YYYY-MM-DD.")
            continue

        if not is_valid_phone(phone):
            print("Invalid phone number. Please enter a 10-digit phone number.")
            continue

        if not is_valid_email(email):
            print("Invalid email address.")
            continue

        age = calculate_age(dob)
        return name, dob, phone, email, age

# save to text 
def save_to_text(employee_details):
    with open("employee_details.txt", "w") as file:
        for detail in employee_details:
            file.write(", ".join(map(str, detail)) + "\n")

#save  to Excel 
def save_to_excel(employee_details):
    workbook = Workbook()
    sheet = workbook.active
    sheet.append(["Name", "DOB", "Phone", "Email", "Age"])
    for detail in employee_details:
        sheet.append(detail)
    workbook.save("employee_details.xlsx")

#save  to PDF
def save_to_pdf(employee_details):
    pdf = FPDF()
    pdf.add_page()
    pdf.set_font("Arial", size=12)
    for detail in employee_details:
        pdf.cell(200, 10, txt=", ".join(map(str, detail)), ln=True)
    pdf.output("employee_details.pdf")

#bulk read from Excel and store
def bulk_read_from_excel():
    try:
        df = pd.read_excel("bulk_employee_details.xlsx")
        return df.values.tolist()
    except Exception as e:
        print(f"Error reading from Excel: {e}")
        return []


def main():
    employee_details = []

    while True:
        print("\nMenu:")
        print("1. Enter Employee Details")
        print("2. Bulk Read from Excel")
        print("3. Save to Text File")
        print("4. Save to Excel File")
        print("5. Save to PDF File")
        print("6. Exit")
        
        choice = input("Enter your choice: ")

        if choice == '1':
            details = get_employee_details()
            employee_details.append(details)
        elif choice == '2':
            bulk_details = bulk_read_from_excel()
            employee_details.extend(bulk_details)
        elif choice == '3':
            save_to_text(employee_details)
        elif choice == '4':
            save_to_excel(employee_details)
        elif choice == '5':
            save_to_pdf(employee_details)
        elif choice == '6':
            break
        else:
            print("Invalid choice. Please try again.")

if __name__ == "__main__":
    main()


