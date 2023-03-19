# DELEGATES
#### Delegates are used to store multiple methods.
#### It is a type safe function pointer which is used to store information about method

### Steps to work with delegates:
- Step1: Complete class level code like variables, methods, etc...

        public class test
        {
          public void show()
          {
          }
        }
        
- Step2: Create delegate.      **syntax: <access modifier> delegate returntype delegatename();**
- Step3: Create object to class.
- Step4: Create an object for delegate and store the method value in.
- Step5: Call the delegate     **syntax: Delegate objectname();**

#### Types of delegates:-
- Single Cast
- Multicast

#### Note:-
1. We can add and store multiple methods for a delegate class
2. When we call the delegate, it wills cal all the methods
3. We can add multiple methods to delegates, by using “+ and =”
4. To remove methods from delegates using “- and =”

# MultiThreading
##### Creating our own execution process is called multi threading
##### To work with threading we have to import the name space **“System.Threading"**
