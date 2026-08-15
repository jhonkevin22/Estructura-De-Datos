def sumar(num1, num2):
    return num1 + num2

def restar(num1, num2):
    return num1 - num2

def multiplicar(num1, num2):
    return num1 * num2

def dividir(num1, num2):
    if num2 == 0:
        return "no se puede dividir por 0"
    return num1 / num2
def main():
    num1 = 50
    num2 = 0

    print("sumar:", sumar(num1, num2))
    print("restar:", restar(num1, num2))
    print("multiplicar:", multiplicar(num1, num2))
    print("dividir:", dividir(num1, num2))

if __name__== "__main__":
    main()
