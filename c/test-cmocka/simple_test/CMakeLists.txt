project(simple-cmocka C)

### The most simple test
add_cmocka_test(simple_test
        SOURCES simple_test.c
        LINK_LIBRARIES cmocka-static)
add_cmocka_test_environment(simple_test)
