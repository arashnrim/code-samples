# Print string
print("Hello World")

# String Formatting with a name variable
name = "John"
print(f"Hello {name}")

# String formatting for table aligned right 1-12 multiplication with input and headers
num = int(input("Enter a number: "))
print('Number    Multiplied')
for i in range(1, 13):
    print("{:<6}    {:>10}".format(i, i * num))

# Create function to calculate bmi
def bmi(weight, height):
    return weight / height ** 2

# Call function
print(bmi(70, 1.8))