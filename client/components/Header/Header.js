import styles from './Header.module.css'

const Header = () => {
    return (
        <header className={styles.header_container}>
            <nav className={styles.nav_container}>
               <h1 className={styles.headerTitle}>ZABITA TAKİP SİSTEMİ</h1>
               <img className={styles.logo} src='policeman.png' />
            </nav>
        </header>
    )
}

export default Header
