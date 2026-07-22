class Dog: 
 def speak(self): return 'Woof'
class Factory:
 def create(self): return Dog()
print(Factory().create().speak())