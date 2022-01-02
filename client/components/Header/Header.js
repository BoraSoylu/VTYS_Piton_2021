import styles from './Header.module.css'

const Header = () => {
    return (
        <header className={styles.header_container}>
            <nav className={styles.nav_container}>
               <div>item</div>
               <div>item</div>
               <div>item</div>
               <div>item</div>
            </nav>
        </header>
    )
}

export default Header
