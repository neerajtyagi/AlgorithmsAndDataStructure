## Problem: **LRU - Least recently used replacement cache with of fixed length with O(1)**

Cache of fixed lenght should be maintained with below condition statements.

1. If item is not in cache it should be fetched from main data source and cached.
2. If item is in cached then item should be returned from cache.
3. Only most recent N items should be in cache, rest all will be cleared as per FIFO.

