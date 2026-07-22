def linear(a,t):
 return next((i for i,v in enumerate(a) if v==t),-1)
print(linear([1,2,3],2))