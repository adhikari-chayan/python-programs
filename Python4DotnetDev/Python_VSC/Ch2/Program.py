import math
def demo_print_greeting():
    print("Hello World!!")

def demo_local_variable():
    a_variable=7
    a_variable="The name is 007"
    print(a_variable)

name="Unknown"

def demo_global_variable():
    global name
    name="Paul"
    print(name+"y")     

def demo_function_params(first,last):
    print("The name is "+first+" "+last)

def demo_function_return(first,last):
    full_name=first+" "+last
    return "The full name is "+full_name

def demo_function_default(first="Someone",last="Unknown"):
    full_name=first+" "+last
    return "The full name is "+full_name

def demo_arithmetic():
    print("\nDemo Arithmetic\n")
    print("7+2=",7+2)
    print("7-2=",7-2)
    print("7*2=",7*2)
    print("7/2=",7/2)
    print("7%2=",7%2)
    print("7**2=",7**2)
    print("7//2=",7//2)
    print("math.floor(7/2)=",math.floor(7/2))
    print("math.ceil(7/2)=",math.ceil(7/2))

def demo_function_calls():
    demo_function_params("James","Bond")
    print(demo_function_return("James","Bond"))
    print(demo_function_default(last="Bond"))
    print(demo_function_return)


def main():
    #demo_print_greeting()
    #demo_local_variable()    
    #demo_global_variable();print(name)
    #demo_arithmetic()
    demo_function_calls()

if __name__=="__main__":
    main()