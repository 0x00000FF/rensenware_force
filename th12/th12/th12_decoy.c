#include <stdio.h>
#include <Windows.h>

const LPVOID difft_target_ptr = (LPVOID)0x004AEBD0;
const LPVOID score_target_ptr = (LPVOID)0x004B0C44;

int main()
{
	DWORD errcode;

	LPVOID difft = VirtualAlloc(difft_target_ptr,
		4,
		MEM_COMMIT | MEM_RESERVE, PAGE_READWRITE);
	LPVOID score = VirtualAlloc(score_target_ptr,
		4,
		MEM_COMMIT | MEM_RESERVE, PAGE_READWRITE);

	errcode = GetLastError();

	printf("STATUS: %d\n", errcode);
	if (errcode) {
		puts("Failed to set decoy! Try again.");
		getchar();

		return 0;
	}

	*((int*)difft_target_ptr) = 3;
	*((int*)score_target_ptr) = 30000000;

	puts("Decoy set. Hit enter to exit when your problem is solved.");
	getchar();

	VirtualFree(difft, 4, MEM_DECOMMIT);
	VirtualFree(score, 4, MEM_DECOMMIT);
	return 0;
}
