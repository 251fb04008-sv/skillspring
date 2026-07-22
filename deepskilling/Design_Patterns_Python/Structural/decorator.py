def deco(f):
 def w(): print('Before');f();print('After')
 return w
@deco
def hi(): print('Hi')
hi()