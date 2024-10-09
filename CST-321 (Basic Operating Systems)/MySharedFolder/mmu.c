#include <stdio.h>
#include <stdbool.h>



#define VIRTUAL_MEMORY_SIZE 0x000FFFFF
#define PHYSICAL_MEMORY_SIZE 0x0007FFFF


// Function to Convert to Binary
void convertPrintBinary(unsigned int number, char* bits)
{
    for (int i = 15; i >= 0; i--)
    {
        bits[i] = (number & 1) + '0';
        number >>= 1;
    }
    bits[16] = '\0';
}


// Function to Print out Binary Number
void printBinary(char* bits)
{
    printf("%s\n", bits);
}


// Function to Initialize Page Table
void initializePageTable(unsigned int pageTable[], int pageSize)
{
    int pageTableSize = VIRTUAL_MEMORY_SIZE / pageSize; // find table size
    unsigned int physicalAddress = 0;                   // start physical address at 0
    for (int i = 0; i < pageTableSize; i++)
    {
        pageTable[i] = physicalAddress;                 // set pageTable[i] to physical address
        physicalAddress += pageSize;                    // increment physical address by page size
    }
}


// Function to Convert Virtual Memory Address to Physical Memory Address
unsigned int convertVirtualToPhysical(unsigned int virtualAddress, unsigned int pageTable[], int pageSize)
{
    int pageTableIndex = virtualAddress / pageSize;                     // find table index by virtual address / page size
    return pageTable[pageTableIndex] + (virtualAddress % pageSize);     // return the value
}


// Driver Function
int main()
{
    // variable declarations
    int pageSize;
    unsigned int virtualAddress;

    // get page size from user
    printf("Enter the page size (4095 or 8191): ");
    scanf("%d", &pageSize);

    if (pageSize != 4095 && pageSize != 8191)
    {
        printf("Invalid page size!\n");
        return 0;
    }

    // get page size in binary and hexadecimal
    char binaryPageSize[17];
    convertPrintBinary(pageSize, binaryPageSize);
    printf("Page size in binary: %s\n", binaryPageSize);
    printf("Page size in hexadecimal: 0x%04X\n", pageSize);

    // initialize the page table 
    int pageTableSize = VIRTUAL_MEMORY_SIZE / pageSize;
    unsigned int pageTable[pageTableSize];
    initializePageTable(pageTable, pageSize);

    // prompt user for hexadecimal virtual address
    printf("Enter a hexadecimal virtual memory address: ");
    scanf("%x", &virtualAddress);
    printf("Virtual memory address in hexadecimal: 0x%08X\n", virtualAddress);

    // convert input to physical address
    unsigned int physicalAddress = convertVirtualToPhysical(virtualAddress, pageTable, pageSize);

    // determine if it fits or if it is on disk
    if (physicalAddress <= PHYSICAL_MEMORY_SIZE)
    {
        printf("Physical memory address in hexadecimal: 0x%08X\n", physicalAddress);
    }
    else
    {
        printf("Currently On Disk\n");
    }

    return 0;
}