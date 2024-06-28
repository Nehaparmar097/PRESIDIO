def primes_up_to(n):
    if n < 2:
        return []
    primes = [True] * (n + 1)
    primes[0] = primes[1] = False
    for i in range(2, int(n**0.5) + 1):
        if primes[i]:
            for j in range(i * i, n + 1, i):
                primes[j] = False
    return [i for i, prime in enumerate(primes) if prime]


number = 30
print(primes_up_to(number))  