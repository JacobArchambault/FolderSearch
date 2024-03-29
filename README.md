# FolderSearch
A file I/O application recursively copying files to an output directory based on user prompts for filters by date, regex pattern, number of files to match per subdirectory. 

The main branch of the application uses a decorator pattern, with heavy use of dependency injection and multiple implementations of a common interface to allow various filters to be added on based on user prompts before recursively copying the files from a user-specied source directory to a user-specified output directory.

Other branches show how to implement the same functionality within a Functional Programming paradigm, and again in a hybrid functional-procedural style.
