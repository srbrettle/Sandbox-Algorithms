import random
import string

vowels = ['a','e','i','o','u']
consonants = ['b','c','d','f','g','h','j','k','l','m','n','p','q','r','s','t','v','x','y','z']

def generate_cvc_password(splitter):
    return generate_cvc() + splitter + generate_cvc() + splitter + generate_cvc()

def generate_cvc():
    return random.choice(consonants) + random.choice(vowels) + random.choice(consonants)
    
def random_password(length):
    password = ""
    options = string.punctuation + string.digits + string.ascii_letters
    for n in range(0,length):
        password += random.choice(options)
    return password
    
def random_password_without_specials(length):
    password = ""
    options = string.digits + string.ascii_letters
    for n in range(0,length):
        password += random.choice(options)
    return password

# Print examples
print('Random Characters:')
print (random_password(18))
print (random_password(18))
print (random_password(18))
print (random_password(18))
print (random_password(18) + "\r\n")
print('Random Characters without Special Characters:')
print (random_password_without_specials(18))
print (random_password_without_specials(18))
print (random_password_without_specials(18))
print (random_password_without_specials(18))
print (random_password_without_specials(18) + "\r\n")
print("Random CVC Type:")
print(generate_cvc_password('-'))
print(generate_cvc_password('-'))
print(generate_cvc_password('-'))
print(generate_cvc_password('-'))
print(generate_cvc_password('-') + "\r\n")
print("Random CVC Type Without Splitter:")
print(generate_cvc_password(''))
print(generate_cvc_password(''))
print(generate_cvc_password(''))
print(generate_cvc_password(''))
print(generate_cvc_password('') + "\r\n")
