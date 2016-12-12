// P1778 vigenere密码
// https://vijos.org/p/1778
// by Equim

#include <cstdio>
#include <cstring>

int main()
{
	// INPUT
	char key[101];
	char ciphertext[1001];
	char plaintext[1001];
	scanf("%s", key);
	scanf("%s", ciphertext);
	
	// PROCESS
	strlwr(key);
	int keyLength = strlen(key);
	int i;
	for(i = 0;ciphertext[i]!='\0';i++)
	{
		plaintext[i] = ciphertext[i] - (key[i%keyLength]-'a');
		if ((ciphertext[i] <= 'Z' && plaintext[i] < 'A') || (ciphertext[i] >= 'a' && plaintext[i] < 'a'))
			plaintext[i] += 26;
	}
	plaintext[i] = '\0';
	
	// OUTPUT
	printf("%s", plaintext);
	return 0;
}
