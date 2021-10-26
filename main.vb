
Module VBModule
    Sub Main()
    
    dim num1 as int32
    dim num2 as int32
    dim BMI as string
    dim pre as int32
    
    console.writeline("Enter first weight in KG:  ")
    num1 = console.readline()
    console.writeline("Ok I see the weight is " & num1)
    
    console.writeline("Enter your height in cm:  ")
    num2 = console.readline()
    System.Threading.Thread.Sleep(2500)
    console.writeline("Ok I see the height is " & num2)
    System.Threading.Thread.Sleep(1500)
    console.writeline("Running tasks...")
    System.Threading.Thread.Sleep(2000)
    console.writeline("Calculating...")
    System.Threading.Thread.Sleep(3000)
    num2 = (num2) / 100
    num2 = (num2) * (num2)
    BMI = (num1) / (num2)
    console.writeline("BMI: " & BMI)
    

    
        
    End Sub
End Module

