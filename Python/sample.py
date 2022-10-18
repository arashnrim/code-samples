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
