plugins {
    kotlin("multiplatform") version "2.2.21"
}

repositories {
    mavenCentral()
}

kotlin {
    linuxX64("simplekotlin") {
        binaries {
            sharedLib {
                baseName = "simplekotlinlib"
            }
        }
    }
}
