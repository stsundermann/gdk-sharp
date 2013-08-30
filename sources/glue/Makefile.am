lib_LTLIBRARIES = libgdksharpglue-3.6.4.la

libgdksharpglue_3_6_4_la_SOURCES =

nodist_libgdksharpglue_3_6_4_la_SOURCES = generated.c

libgdksharpglue_3_6_4_la_LDFLAGS = -module -avoid-version -no-undefined

libgdksharpglue_3_6_4_la_LIBADD = $(GDK_LIBS)

INCLUDES = $(GDK_CFLAGS) -I$(top_srcdir)

libgdksharpglue.dll: $(libgdksharpglue_3_6_4_la_OBJECTS) libgdksharpglue.rc libgdksharpglue.def
	./build-dll libgdksharpglue $(VERSION)

CLEANFILES = lib*.a lib*.dll

EXTRA_DIST =
