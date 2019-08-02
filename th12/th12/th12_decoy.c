#include <conio.h>
#include <stdio.h>
#include <Windows.h>

#define ALLOC_OPTIONS (MEM_COMMIT | MEM_RESERVE), PAGE_READWRITE

#define DIFFICULTY (LPVOID)0x004AEBD0
#define SCORE      (LPVOID)0x004B0C44

int main()
{
	LPVOID diff, score;

	puts("rensenWare Forcer with Decoy Method\n"
	     "===================================\n"
	     "This tool was made to help you to disable rensenWare.\n"
	     "If you are affected such malware and the ransomnote still on you monitor,\n"
	     "Please use this tool to free your files.\n\n"
	     "Press anykey to continue...\n");

	_getch();

	puts("Allocating memory on target address...\n"
		"* If this takes too long, please close this window and retry\n\n");
	do
	{
		diff  = VirtualAlloc(DIFFICULTY, 4, ALLOC_OPTIONS);
		score = VirtualAlloc(SCORE, 4, ALLOC_OPTIONS);
	} while (GetLastError());

	*((int*)DIFFICULTY) = 3;
	*((int*)SCORE) = 30000000;

	puts("*** Decoy SET! Hit any key when your files are okay. ***");
	
	_getch();

	VirtualFree(DIFFICULTY, 4, MEM_DECOMMIT);
	VirtualFree(SCORE     , 4, MEM_DECOMMIT);
	
	return 0;
}
